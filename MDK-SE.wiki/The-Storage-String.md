Sometimes you need to store information that must survive reloading or shutting down the game, or during recompilation of your script. The grid program currently provides only one way to do this: The `Storage` property. This property resides in your script's base class `MyGridProgram` and as such can be accessed by any method or property in your script - but not directly by any subclass (see [the bottom of this page](https://github.com/malware-dev/MDK-SE/wiki/The-Grid-Terminal-System#the-grid-terminal-system-and-subclasses) - "The Grid Terminal System and Subclasses" - for a way to get around that problem).

(See [Handling configuration and storage](Handling-configuration-and-storage) for a more advanced and flexible way to deal with the actual data in Storage)

The `Storage` property is simply a string property:
```csharp
public void Save()
{
    Storage = "My String"
}
```
As you can see, nothing special about its use. The difference between this property and any other is the fact that its content is saved to your disk when the game is saved.

Changing it to just any old string, that's not very useful, is it. What if you need to save something more complicated? Well, I'm afraid you're gonna have to do the hard work yourself. 

The absolutely most simple and primitive way of storing multiple values in the `Storage` is by using [string concatenation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/how-to-concatenate-multiple-strings) or [string.Join](https://msdn.microsoft.com/en-us/library/57a79xd0(v=vs.110).aspx) for saving, and [string.Split](https://msdn.microsoft.com/en-us/library/tabh47cf(v=vs.110).aspx) for loading.

I would recommend you using `Program()` to read your `Storage`, and `Save()` to write to it and leave it at that, to avoid doing too much work too often.

```csharp
string _someTextDescription;
int _someImportantNumber;

public Program() 
{
    string[] storedData = Storage.Split(';');
    // If there's at least one item in the storage data...
    if (storedData.Length >= 1)
    {
        // Retrieve first item. C# arrays are 0-indexed, meaning the first item in the list is item 0.
        _someTextDescription = storedData[0];
    }

    // If there's at least two items in the storage data...
    if (storedData.Length >= 2)
    {
        // Retrieve the second item. This time we want to try to convert it into a number.
        int.TryParse(storedData[1], out _someImportantNumber);
    }
}

public void Save()
{
    // Combine the state variables into a string separated by the ';' character
    Storage = string.Join(";",
        _someTextDescription ?? "",
        _someImportantNumber
    );
}
```
Note the use of [int.TryParse](https://msdn.microsoft.com/en-us/library/f02979c7(v=vs.110).aspx) in the `Program()`. We use this because we want to do our best to gracefully fail if the string contains something we don't understand. This can happen if we change the format of the string, or if we somehow manage to make a mistake during saving. Better safe than sorry.

In the same vein, note that we add the [null-coalescing operator](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-conditional-operator) `??` to the line containing `_someTextDescription`. This is to handle the case where that field might be null, in which case we store an empty string instead.

This method of using `Storage` should be enough for most smaller scripts.
