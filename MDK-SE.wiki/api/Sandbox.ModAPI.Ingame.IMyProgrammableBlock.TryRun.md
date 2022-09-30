← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyProgrammableBlock](Sandbox.ModAPI.Ingame.IMyProgrammableBlock)

### 概要

```csharp
public bool TryRun(string argument)
```

Attempts to run this programmable block using the given argument. An already running programmable block cannot be run again. This is equivalent to running`block.ApplyAction("Run", argumentsList);`This should be called from an ingame script. Do not use in mods.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

`true`if the action was applied,`false`otherwise

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) argument
