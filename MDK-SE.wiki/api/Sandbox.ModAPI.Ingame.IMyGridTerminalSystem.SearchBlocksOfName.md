← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)

### 概要

```csharp
public void SearchBlocksOfName(string name, List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null)
```

Fills the provided list with the blocks reachable by this grid terminal system. This means all blocks on the same grid, or connected via rotors, pistons or connectors.

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) name
* [List&lt;IMyTerminalBlock&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) blocks
* [Func&lt;IMyTerminalBlock, bool&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) collect
