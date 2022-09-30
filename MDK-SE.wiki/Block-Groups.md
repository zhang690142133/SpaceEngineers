A block group (`IMyBlockGroup`) is a subset of the [Grid Terminal System](https://github.com/malware-dev/MDK-SE/wiki/The-Grid-Terminal-System) representing the groups created in a ship's terminal. They are retrieved either by calling `GridTerminalSystem.GetBlockGroups` or `GridTerminalSystem.GetBlockGroupWithName`.

These are the properties and methods available to you from a block group:

* `Name`
    Gets the name of the group. This is the name checked when you call `GridTerminalSystem.GetBlockGroupWithName`.
    ```csharp
    // Lists the name of the group and the names of all the blocks within the group.
    IMyBlockGroup group = GridTerminalSystem.GetBlockGroupWithName("A Group");
    if (group == null)
    {
        Echo("Group not found");
        return;
    }
    Echo($"{group.Name}:");
    List<IMyTerminalBlock> blocks = new List<IMyTerminalBlock>();
    group.GetBlocks(blocks);
    foreach (var block in blocks)
    {
        Echo($"- {block.CustomName}");
    }
    ```
    This example uses [string interpolation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interpolated-strings) as indicated by the `$` prefix, a very useful technique.

* `GetBlocksOfType`
    Allows you to retrieve a list of blocks of a specific type, optionally filtered by a given collect predicate.
    ```csharp
    // Retrieve a named group
    IMyBlockGroup group = GridTerminalSystem.GetBlockGroupWithName("A Group");
    List<IMyInteriorLight> lights = new List<IMyInteriorLight>();
    // Fetch the blocks from that group. Note that the type designation is implicit
    // here, it's defined by the list above - this is why you don't need to specify
    // the type in <>.
    group.GetBlocksOfType(lights);
    ```
    ```csharp
    // Retrieve a named group
    IMyBlockGroup group = GridTerminalSystem.GetBlockGroupWithName("A Group");
    // Create a list containing all interior lights in the group, but store them
    // in a generic list containing blocks of the IMyTerminalBlock type
    List<IMyTerminalBlock> lights = new List<IMyTerminalBlock>();
    // Fetch the blocks from that group. Now we _do_ need to specify the block
    // type we want, because _all_ blocks are IMyTerminalBlock.
    group.GetBlocksOfType<IMyInteriorLight>(lights);
    ```
    ```csharp
    // Retrieve a named group
    IMyBlockGroup group = GridTerminalSystem.GetBlockGroupWithName("A Group");
    // Create a list containing all interior lights that are currently on
    List<IMyInteriorLight> lights = new List<IMyInteriorLight>();
    // Fetch the blocks from that group - if they're enabled. Again, the type
    // is implicit.
    block.GetBlocksOfType(lights, light => light.Enabled);
    ```