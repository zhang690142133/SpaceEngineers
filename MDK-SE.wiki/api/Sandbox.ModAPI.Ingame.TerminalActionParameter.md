← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### TerminalActionParameter Struct

```csharp
public struct TerminalActionParameter
```

Implements terminal action parameter

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

#### Fields

[static TerminalActionParameter Empty](Sandbox.ModAPI.Ingame.TerminalActionParameter.Empty)

> Gets an empty parameter.

[TypeCode TypeCode](Sandbox.ModAPI.Ingame.TerminalActionParameter.TypeCode)

> Gets the type code

[object Value](Sandbox.ModAPI.Ingame.TerminalActionParameter.Value)

> Gets the value

#### Properties

[bool IsEmpty { get; }](Sandbox.ModAPI.Ingame.TerminalActionParameter.IsEmpty)

> Gets whether this action is empty

#### 方法

[static TerminalActionParameter Deserialize(string serializedValue, TypeCode typeCode)](Sandbox.ModAPI.Ingame.TerminalActionParameter.Deserialize)

> Creates a [TerminalActionParameter](Sandbox.ModAPI.Ingame.TerminalActionParameter) from a serialized value in a string and a type code.

[static TerminalActionParameter Get(object value)](Sandbox.ModAPI.Ingame.TerminalActionParameter.Get)

> Creates a [TerminalActionParameter](Sandbox.ModAPI.Ingame.TerminalActionParameter) from the given value.

[MyObjectBuilder_ToolbarItemActionParameter GetObjectBuilder()](Sandbox.ModAPI.Ingame.TerminalActionParameter.GetObjectBuilder)

> Gets object builder for the action

