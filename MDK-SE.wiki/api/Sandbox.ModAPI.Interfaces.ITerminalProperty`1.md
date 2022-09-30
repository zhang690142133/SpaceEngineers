← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### ITerminalProperty&lt;TValue&gt; Interface

```csharp
public interface ITerminalProperty<TValue>: ITerminalProperty
```

**命名空间:** [Sandbox.ModAPI.Interfaces](Sandbox.ModAPI.Interfaces)  
**Assembly:** Sandbox.Common.dll

**Implements:**  
* [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)

#### Properties

[string Id { get; }](Sandbox.ModAPI.Interfaces.ITerminalProperty.Id)

> Property Id (value name)  
>   
> _Inherited from [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)_

[string TypeName { get; }](Sandbox.ModAPI.Interfaces.ITerminalProperty.TypeName)

> Property type (bool - [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean?view=netframework-4.6) , float - [System.Single](https://docs.microsoft.com/en-us/dotnet/api/system.single?view=netframework-4.6) , color - [Color](VRageMath.Color) )  
>   
> _Inherited from [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)_

#### 方法

[TValue GetDefaultValue(IMyCubeBlock block)](Sandbox.ModAPI.Interfaces.ITerminalProperty`1.GetDefaultValue)

> 

[TValue GetMaximum(IMyCubeBlock block)](Sandbox.ModAPI.Interfaces.ITerminalProperty`1.GetMaximum)

> 

[TValue GetMinimum(IMyCubeBlock block)](Sandbox.ModAPI.Interfaces.ITerminalProperty`1.GetMinimum)

> 

[TValue GetValue(IMyCubeBlock block)](Sandbox.ModAPI.Interfaces.ITerminalProperty`1.GetValue)

> 

[void SetValue(IMyCubeBlock block, TValue value)](Sandbox.ModAPI.Interfaces.ITerminalProperty`1.SetValue)

> 

[TValue GetMininum(IMyCubeBlock block)](Sandbox.ModAPI.Interfaces.ITerminalProperty`1.GetMininum)

> _**Obsolete:** Use GetMinimum instead_

