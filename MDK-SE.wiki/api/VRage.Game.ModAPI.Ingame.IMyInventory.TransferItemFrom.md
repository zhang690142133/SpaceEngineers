← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)

### 概要

```csharp
public bool TransferItemFrom(IMyInventory sourceInventory, MyInventoryItem item, MyFixedPoint? amount = default)
```

Attempts to transfer item from one inventory to another.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True in case item was successfully transferred, false otherwise

### 参数

* [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory) sourceInventory
* [MyInventoryItem](VRage.Game.ModAPI.Ingame.MyInventoryItem) item
* [MyFixedPoint?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) amount
### 概要

```csharp
public bool TransferItemFrom(IMyInventory sourceInventory, int sourceItemIndex, int? targetItemIndex = default, bool? stackIfPossible = default, MyFixedPoint? amount = default)
```

Attempts to transfer item from one inventory to another.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True in case item was successfully transferred, false otherwise

### 参数

* [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory) sourceInventory
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceItemIndex
* [int?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) targetItemIndex
* [bool?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) stackIfPossible
* [MyFixedPoint?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) amount
