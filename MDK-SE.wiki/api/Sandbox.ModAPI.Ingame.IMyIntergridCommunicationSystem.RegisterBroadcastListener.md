← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyIntergridCommunicationSystem](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem)

### 概要

```csharp
public IMyBroadcastListener RegisterBroadcastListener(string tag)
```

Registers broadcast listener with given tag for current programmable block. In case there is already another active broadcast lister with given tag new listener is NOT registered and the already active one is returned instead.

### 返回

[IMyBroadcastListener](Sandbox.ModAPI.Ingame.IMyBroadcastListener)

Active broadcast listener for given tag.

### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) tag
