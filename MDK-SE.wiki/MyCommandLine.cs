MyCommandLine _commandLine = new MyCommandLine();
Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

public Program()
{
    _commands["cycle"] = Cycle;
}

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
        else if (_commands.TryGetValue(_commandLine.Argument(0), out commandAction))
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
