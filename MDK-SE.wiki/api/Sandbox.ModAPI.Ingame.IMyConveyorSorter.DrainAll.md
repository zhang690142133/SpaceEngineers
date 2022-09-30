← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyConveyorSorter](Sandbox.ModAPI.Ingame.IMyConveyorSorter)

### 概要

```csharp
public bool DrainAll { get; set; }
```

Determines whether the sorter should drain any inventories connected to it and push them to the other side - as long as the items passes the filtering as defined by the filter list ( [GetFilterList(List<MyInventoryItemFilter>)](Sandbox.ModAPI.Ingame.IMyConveyorSorter.GetFilterList) ) and [Mode](Sandbox.ModAPI.Ingame.IMyConveyorSorter.Mode) .

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

