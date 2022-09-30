**Note: Terminal actions and properties are orders of magnitude slower than their equivalent C# members. As such it is highly recommended you use proper C# code and _not_ terminal actions and properties, for less overhead, whereever this is possible.**


In addition to the normal C# properties, fields and methods, Space Engineers introduces a couple of unique concepts to the programmable block: The Terminal Properties and Actions. These are usually - but not entirely exclusively - connected directly to user interface components shown in the block's terminal. They are _not_ accessed via normal interfaces, but via specialized methods available for _any_ block. However note that it is highly recommended that you do your best to use the proper C# code wherever possible, since these will always be the most performant and least bug prone to use - not to mention that if you use Visual Studio, these will show up in the intellisense popup, as opposed to the terminal properties and actions which will not. At the time of writing this tutorial, not all Terminal items have gotten their proper C# interface access, in which case you will have to resort to the Terminal access.

#### Terminal Properties
Terminal properties are ways to access the values of the user interface components.

You can get the value of a terminal property by calling the method `GetValue<T>`. This is a [generic method](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods), so you need to specify the type of the value you wish to retrieve yourself.
```csharp
IMyTerminalBlock block = GridTerminalSystem.GetBlockWithName("Interior Light");
Color color = block.GetValue<Color>("Color");
```
Here I'm retrieving the color of an interior light. Note that I did _not_ specifically check that the block is actually a door; this is not necessary. However if the block you retrieve does not have the property specified, your script will crash with a `NullReferenceException`.

Similarily, you can _set_ the value of a terminal property by calling the method `SetValue<T>`.
```csharp
IMyTerminalBlock block = GridTerminalSystem.GetBlockWithName("Interior Light");
block.SetValue<Color>("Color", Color.Red);
```
This code will change the color of the light to red.

#### Listing Available Terminal Properties
The following example lists out the IDs of all the terminal properties in the block.
```csharp
List<ITerminalProperty> properties = new List<ITerminalProperty>();
block.GetProperties(properties);
foreach (var property in properties)
{
    Echo(property.Id);
}
```

#### Terminal Actions
Terminal actions are the same actions you see when dragging a block from the block area to a toolbar in a sensor, timer block, button panel etc. 

You invoke a terminal action by calling the method `ApplyAction` on a filled reference to a block:
```csharp
IMyTerminalBlock block = GridTerminalSystem.GetBlockWithName("Interior Door");
block.ApplyAction("Open_On");
```
This particular action will open the door retrieved. Note again that if the block you retrieve does not have the action specified, your script will crash with a `NullReferenceException`.

#### Listing Available Terminal Actions
The following example lists out the IDs and display text of all the actions in the block.
```csharp
List<ITerminalAction> actions = new List<ITerminalAction>();
block.GetActions(actions);
foreach (var action in actions)
{
    Echo($"{action.Id}: {action.Name}");
}
```

Or, you could just [search the list I've already generated for you](https://github.com/malware-dev/MDK-SE/wiki/List-Of-Terminal-Properties-and-Actions).
