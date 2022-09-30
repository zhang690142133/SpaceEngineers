← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)

### 概要

```csharp
public bool CanTransferItemTo(IMyInventory otherInventory, MyItemType itemType)
```

Determines if there is working conveyor connection for item of give type to be transferred to other inventory.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if there is working conveyor connection between inventories so that item of give type can by transferred, false otherwise

### 参数

* [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory) otherInventory
* [MyItemType](VRage.Game.ModAPI.Ingame.MyItemType) itemType
