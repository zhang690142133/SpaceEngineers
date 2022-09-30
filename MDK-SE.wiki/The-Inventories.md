In Space Engineers, _inventories_ are objects that are available on a block level. Any block may have any number of inventories available. For example, the standard cargo block has one inventory available, while the assemblers have 2: _input_ (raw materials) and _output_ (product).

We can access these inventories in the programmable block by checking the blocks' `InventoryCount` property. In this tutorial I will assume you already understand how to use [the terminal system](The-Grid-Terminal-System), and that you understand [the anatomy of a script](The-Anatomy-Of-A-Script). I will also assume you have gained an understanding of [string interpolation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated). All of these things are outside of the scope of this tutorial.

### MyFixedPoint
Some of the members belonging to the inventory API uses a strange data type called MyFixedPoint. It is a type designed to contain a value much like `double` or `float`. The hows and why's of this type is beyond the scope of this tutorial but if you're curious, I found [this page](https://www.tutorialspoint.com/fixed-point-and-floating-point-number-representations) explaining the difference between _fixed point_ and _floating point_ decimal values - or you can use your _own_ Google-Fu.

What is _important_ is that you can CAST (convert) the values of these members into a much more useful `double` type, with which you can do all the operations you'll want easily. All you need to do is this:
```csharp
double maxVolume = (double) inventory.MaxVolume;
```


## Example 1: Total Cargo Volume and Capacity

The following example will be iterating through all available blocks in the current construct, and adding up how much inventory space we have _used_ and how much inventory space is _available._ We will not be taking into account block types.

_ps: this script will need to be_ recompiled _in order to recognize new blocks placed_

```csharp
readonly List<IMyTerminalBlock> _blocks = new List<IMyTerminalBlock>();
readonly StringBuilder _textBuffer = new StringBuilder(1024);
readonly IMyTextSurface _display;

public Program()
{
    // Retrieve all the blocks which can be found in this construct.
    GridTerminalSystem.GetBlocksOfType<IMyTerminalBlock>(_blocks, block => block.IsSameConstructAs(Me));

    // Configure the programmable block display to show simple text output
    _display = Me.GetSurface(0);
    _display.ContentType = ContentType.TEXT_AND_IMAGE;
    _display.TextPadding = 0.1f;

    // We don't want to do this job too often, so let's just update once every 100 ticks
    Runtime.UpdateFrequency = UpdateFrequency.Update100;
}

public void Main(string argument, UpdateType updateSource)
{
    // A constant for newline - just for readability
    const string br = "\n";

    // Get the cargo information
    var cargoSpace = CalculateCargoSpace(_blocks);

    // Write the cargo information to the programmable block display
    _textBuffer.Clear();
    _textBuffer.Append(br);
    _textBuffer.Append($"  Used volume: {cargoSpace.UsedLiters:N2}L{br}");
    _textBuffer.Append($"  Capacity: {cargoSpace.CapacityLiters:N2}L{br}");
    _textBuffer.Append($"  Usage: {(cargoSpace.UsageRatio * 100):N1} %");
    _display.WriteText(_textBuffer);
}

/// <summary>
///     Calculates the cargo space of the provided blocks
/// </summary>
/// <param name="blocks">A list of blocks to scan for inventories</param>
/// <returns>A value containing cargo space information</returns>
public CargoSpace CalculateCargoSpace(List<IMyTerminalBlock> blocks)
{
    double used = 0;
    double capacity = 0;
    // We iterate through all the blocks,
    foreach (var block in blocks)
    {
        // and then we iterate and retrieve all individual inventories for each of those blocks.
        for (var i = 0; i < block.InventoryCount; i++)
        {
            // If the block has no inventories, block.InventoryCount will be 0,
            // and we will never enter this code block.

            // Get the inventory manager at the index specified by i
            var inventory = block.GetInventory(i);

            // CurrentVolume and MaxVolume are both of the type MyFixedPoint. We will CAST
            // (convert the data type) to a double type instead, which is more useful to us.
            var currentVolume = (double) inventory.CurrentVolume;
            var maxVolume = (double) inventory.MaxVolume;

            // Now we add up the current- and max volumes to our total
            // tally.
            used += currentVolume;
            capacity += maxVolume;
        }
    }

    // When we get here, we've looped through all the inventories in the given blocks,
    // and we can create the final informational object - and return it to the user.
    return new CargoSpace(used, capacity);
}

/// <summary>
///     A simple object to contain the final information about
///     the cargo space
/// </summary>
public struct CargoSpace
{
    /// <summary>
    ///     Create a new CargoSpace object with the given values
    /// </summary>
    /// <param name="usedLiters">The occupied volume in Liters</param>
    /// <param name="capacityLiters">The total available volume in Liters</param>
    public CargoSpace(double usedLiters, double capacityLiters)
    {
        UsedLiters = usedLiters;
        CapacityLiters = capacityLiters;
        UsageRatio = capacityLiters > 0 ? usedLiters / capacityLiters : 1.0;
    }

    /// <summary>
    ///     Contains the occupied inventory volume represented in Liters
    /// </summary>
    public readonly double UsedLiters;

    /// <summary>
    ///     Contains the total available space represented in Liters
    /// </summary>
    public readonly double CapacityLiters;

    /// <summary>
    ///     Contains the usage ratio (a value between 0.0 to 1.0)
    /// </summary>
    public readonly double UsageRatio;
}
```