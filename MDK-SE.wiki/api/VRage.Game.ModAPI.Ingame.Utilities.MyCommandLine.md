← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyCommandLine Class

```csharp
public class MyCommandLine
```

A utility class to parse arguments from a command line string. Switches are defined with hyphen (-switch). Quotes can be placed around an argument to parse verbatim, but inner quotes will be copied verbatim. For example, "one"two" will result in the string one"two.

**命名空间:** [VRage.Game.ModAPI.Ingame.Utilities](VRage.Game.ModAPI.Ingame.Utilities)  
**Assembly:** VRage.Game.dll

#### Properties

[int ArgumentCount { get; }](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.ArgumentCount)

> Returns the number of non-switch arguments

[ItemCollection Items { get; }](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.Items)

> Contains all items, both arguments and switches

[SwitchCollection Switches { get; }](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.Switches)

> Contains a list of all detected switches

#### Constructors

[MyCommandLine()](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine..ctor)

> 

#### 方法

[string Argument(int index)](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.Argument)

> Returns the argument at the given index. Switches are not counted.

[void Clear()](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.Clear)

> Clears all arguments

[bool Switch(string name)](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.Switch)

> Determines whether the given switch is set. Switches are specified without their prefixed hyphen.

[string Switch(string name, int relativeArgument)](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.Switch)

> Gets an argument of a switch. For example, using`Switch("key", 0)`on the command line`someOtherArgument -key value`will return`value`.

[bool TryParse(string argument)](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.TryParse)

> Attempts to parse the given string as a command line

