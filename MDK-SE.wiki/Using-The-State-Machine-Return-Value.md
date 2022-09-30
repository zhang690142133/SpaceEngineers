** INCOMPLETE DOCUMENT **

In the [yield state machine example](Easy-and-Powerful-State-Machine.md) the return value `bool` in the `IEnumerator<bool>` was not in use. It was just a placeholder simply because the type requires it. In _this_ example I will show how you can use this return value in a more helpful way. We will introduce a simple `TaskManager`, and the return value of the yield will tell this task manager how many ticks should be _skipped_ before the next section of the method is invoked.



## The Task Manager

The first thing we need is a data type to represent a running operation.

```csharp
public struct Task
{
    // Create a new Task
    public Task(long id, IEnumerator<int> operation, int skip) 
    {
        Id = id;
        Operation = operation;
        Skip = skip;
    }

    // The unique ID of this particular task
    public readonly long Id;

    // Represents the currently running operation itself. Note that the return value is now
    // int rather than bool. This will be explained later.
    public readonly IEnumerator<int> Operation;

    // The number of ticks to skip before moving Operation to the next step.
    public readonly int Skip;
}
```

Then we need the actual task manager.

```csharp
public class TaskManager
{
    // A reference to your script program
    Program _program;
    // A quick lookup of all running task IDs
    HashSet<long> _runningTaskIds = new HashSet<long>();
    // A list of the currently running tasks
    List<Task> _runningTasks = new List<Task>();
    // A source to generate task IDs
    long _idSrc = 0;
    
    // Create a new task manager. We pass in the Program in order to be able to
    // change the runtime frequency.
    public TaskManager(Program program)
    {
        _program = program;
    }
    
    // Enqueue a new operation for distributed execution
    public long Run(IOperation<int> operation) 
    {
        // The following is a combination of two statements. First it increments _idSrc
        // by one (++_idSrc is equivalent to _idSrc = _idSrc + 1), then it assigns this
        // incremented value to the id variable.
        var id = ++_idSrc;
        
        // Then we create a new Task container. We give this container the ID, the
        // operation, and we tell it that we don't want any initial tick skipping.
        var task = new Task(id, operation, 0)
            
		// Finally we add the task to the list and the ID to the lookup table.
        _runningTasks.Add(task);
        _runningTaskIds.Add(id);
        
        // Then we must make sure the runtime frequency is set to run at least once more.
        // Note that we add it with a binary OR operator in order to _not_ overwrite any
        // frequencies defined elsewhere in the program.
        _program.Runtime.UpdateFrequency |= UpdateFrequency.Once;
        
        // Then we return the ID for user reference.
        return id;
    }
    
    // Determines if the task with the given ID is still running.
    public bool IsRunning(long id) => _runningTaskIds.Contains(id);
    
    // Runs the next step of all active operations. Called only once in Main.
    public void Tick()
    {
        // Loop through all tasks and update them
        for (var i = 0; i <= _runningTasks.Count; i++)
        {
            var task = _runningTasks[i];
            // If skipping has been requested for this task, we decrement the skip
            // count, register the new task with the corrected skip and continue
            // with the _next_ task without running this one.
            if (task.Skip > 0) 
            {
                _runningTasks[i] = new Task(task.Id, task.Operation, task.Skip - 1);
                continue;
            }
            
            // If the MoveNext method of the operation return false, then there are no more
            // steps to the operation and we must finish it.
            if (!task.Operation.MoveNext()) 
            {
                // Remove the ID from the quick lookup
                _runningTaskIds.Remove(task.Id);
                // Remove the currently running task: This uses an extension by Keen which
                // swaps the task to be deleted with the task at the end of the list. This
                // makes it much faster than the default RemoveAt which will shift all items
                // after the index, but preserves order.
                _runningTasks.RemoveAtFast(i);

                // Since we removed this item and got a new item in its place, we need to 
                // redo the same index again in order to process that new item. So we
                // backpedal the iterating index.
                i--;
                
                // Dispose of the operation
                task.Operation.Dispose();
                
                // Nothing more to do, continue with the next task.
                continue;
            }
            
            // Here we will use the yield return value used by your script. The Current 
            // property of the iterator will return the last value you yielded.
            _runningTask[i] = new Task(task.Id, task.Operation, task.Operation.Current);
        }
    }
}
```

