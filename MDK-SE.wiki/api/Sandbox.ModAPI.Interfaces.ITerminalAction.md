← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### ITerminalAction Interface

```csharp
public interface ITerminalAction
```

Describes terminal action interface

**命名空间:** [Sandbox.ModAPI.Interfaces](Sandbox.ModAPI.Interfaces)  
**Assembly:** Sandbox.Common.dll

#### Properties

[string Icon { get; }](Sandbox.ModAPI.Interfaces.ITerminalAction.Icon)

> Gets the icon of the action

[string Id { get; }](Sandbox.ModAPI.Interfaces.ITerminalAction.Id)

> Gets the id of the action

[StringBuilder Name { get; }](Sandbox.ModAPI.Interfaces.ITerminalAction.Name)

> Gets the name of the action

#### 方法

[void Apply(IMyCubeBlock block)](Sandbox.ModAPI.Interfaces.ITerminalAction.Apply)

> Applies action on the block

[void Apply(IMyCubeBlock block, ListReader&lt;TerminalActionParameter&gt; terminalActionParameters)](Sandbox.ModAPI.Interfaces.ITerminalAction.Apply)

> Applies action on the block with specific action parameters

[bool IsEnabled(IMyCubeBlock block)](Sandbox.ModAPI.Interfaces.ITerminalAction.IsEnabled)

> Checks if action is enabled for specific block

[void WriteValue(IMyCubeBlock block, StringBuilder appendTo)](Sandbox.ModAPI.Interfaces.ITerminalAction.WriteValue)

> Writes value for the action

