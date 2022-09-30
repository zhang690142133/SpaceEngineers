← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)

### 概要

```csharp
public bool HasInventory { get; }
```

Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

