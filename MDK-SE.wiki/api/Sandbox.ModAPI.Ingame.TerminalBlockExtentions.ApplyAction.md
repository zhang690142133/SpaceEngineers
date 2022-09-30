← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [TerminalBlockExtentions](Sandbox.ModAPI.Ingame.TerminalBlockExtentions)

### 概要

```csharp
public static void ApplyAction(this IMyTerminalBlock block, string actionName)
```

Finds action by [GetActionWithName(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.GetActionWithName) and calls [Apply(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalAction.Apply) 

### 参数

* [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock) block
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) actionName
### 概要

```csharp
public static void ApplyAction(this IMyTerminalBlock block, string actionName, List<TerminalActionParameter> parameters)
```

Finds action by [GetActionWithName(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.GetActionWithName) and calls [Apply(IMyCubeBlock, ListReader<TerminalActionParameter>)](Sandbox.ModAPI.Interfaces.ITerminalAction.Apply) 

### 参数

* [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock) block
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) actionName
* [List&lt;TerminalActionParameter&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) parameters
