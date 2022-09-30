Once your scripts start to get a little more advanced, you will want to utilize the argument in order to have your script perform multiple operations. For example if you are writing an airlock script, you will want to tell the script to cycle an airlock in or out, and even _which_ airlock to cycle. I won't be telling you how to write an airlock script, but I will be using this as an example in order to show you how to detect and handle the arguments related to such a script. The programmable block API has a built-in command line parser courtesy of yours truly that is designed to be fast and allocation friendly, as well as easy to use.

For those of you who just want to get on with it, [here's a link to the simple demo script used in this tutorial.](MyCommandLine.cs)

This parser is called `MyCommandLine`. The following is the most basic setup, without actually checking any arguments.

```csharp
MyCommandLine _commandLine = new MyCommandLine();

public void Main(string argument)
{
    if (_commandLine.TryParse(argument)) {
        // The command line parser found arguments in the string.
    }
}
```

This code initializes the command line parser, and attempts to parse the incoming argument. If it finds arguments, the `TryParse` method will return `true`. 

## The Argument Formats

The traditional command line formats consists of **arguments** and **switches**. 

An **argument** is either a single `word` or a `"quoted string"` if you need whitespace. The arguments are accessed via their relative position in the string, just like an array - the first argument being argument 0, the second 1 and so on. 

A **switch** is different. In `MyCommandLine` a switch is denoted by prefixing a `word` with a `-hyphen`. A switch can _only_ be words (no whitespace), but it can be placed anywhere in the command line. They will _not_ affect the indexing of the arguments.

Let's use some examples to make this clearer. Take the following command lines:

```
cycle "Airlock 1" in -emergency
-emergency cycle "Airlock 1" in
```

These two command lines consists of three arguments, as seen by `MyCommandLine`.

0. cycle
1. Airlock 1
2. in

and it has a single switch:

* -emergency


Note that it doesn't matter where the `-emergency` switch is placed, it will not affect the indices of the arguments.



## Accessing the arguments and switches

You can check if a given switch has been specified via the `Switch` method. Do not include the hyphen when checking for switches.

```csharp
// check if the -myflag switch is set
bool switchIsSet = _commandLine.Switch("myflag");
```

You retrieve arguments by their ordinal, _not_ counting switches.

```csharp
// retrieve the first argument of the string (either a word or a "quoted string"). The quotes are removed for you.
string arg = _commandLine.Argument(0);
```

Let's take the first command line example again:

```
cycle "Airlock 1" in -emergency
```

Then we will modify the very first example to handle this example in a nice and performant way.

First we will need a way to distinguish between the commands. The first argument, of course, is going to be the command indicator. We will create a dictionary to hold these commands:

```csharp
Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
```

Note that we pass in a case insensitive string comparer, so that we can accept CYCLE as well as cycle. Next we will need to initialize the commands. This we do in the script constructor.

```csharp
public Program() 
{
    // Associate the Cycle method with the cycle command
    _commands["cycle"] = Cycle;
}

public void Cycle()
{
	// This method will hold the code to perform the desired action
}
```

Finally we edit the Main method to use this dictionary to select and execute commands.

```csharp
public void Main(string argument)
{
    if (_commandLine.TryParse(argument))
    {
        Action commandAction;

        // Retrieve the first argument. Switches are ignored.
        string command = _commandLine.Argument(0);

        // Now we must validate that the first argument is actually specified, 
        // then attempt to find the matching command delegate.
        if (command == null)
        {
            Echo("No command specified");
        } 
        else if (_commands.TryGetValue(command, out commandAction))
        {
            // We have found a command. Invoke it.
            commandAction();
        }
        else
        {
            Echo($"Unknown command {command}");
        }
    }
}
```

Finally we must finish the handling of the command specific arguments, in the Cycle method which is associated with the `cycle` command.

```csharp
public void Cycle()
{
    // Check if the "emergency" switch is set.
    bool emergencyCycle = _commandLine.Switch("emergency");

    // Argument no. 1 is the name of the airlock to cycle
    string airlockName = _commandLine.Argument(1);
    if (airlockName == null)
    {
        Echo("Cannot cycle, no airlock specified");
        return;
    }

    // Argument no. 2 should be either "in" or "out", indicating
    // which direction to cycle
    string direction = _commandLine.Argument(2);
    if (direction == null)
    {
        Echo($"Cannot cycle {airlockName}, no direction specified");
        return;
    }
    if (string.Equals(direction, "in", StringComparison.OrdinalIgnoreCase))
    {
        Echo($"Cycling airlock {airlockName} in...");
        // TODO: Begin the cycling of the airlock
    }
    else if (string.Equals(direction, "out", StringComparison.OrdinalIgnoreCase))
    {
        Echo($"Cycling airlock {airlockName} out...");
        // TODO: Begin the cycling of the airlock
    }
    else
    {
        // The argument was none of the expected values
        Echo($"Cannot cycle {airlockName}, cannot understand direction {direction}");
    }
}
```
