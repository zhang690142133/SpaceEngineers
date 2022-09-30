← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)

### 概要

```csharp
public void GetItems(List<MyInventoryItem> items, Func<MyInventoryItem, bool> filter = null)
```

Collects all items present inside this inventory and returns snapshot of the current inventory state.

### 参数

* [List&lt;MyInventoryItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) items
* [Func&lt;MyInventoryItem, bool&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) filter
