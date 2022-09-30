← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyConveyorSorter](Sandbox.ModAPI.Ingame.IMyConveyorSorter)

### 概要

```csharp
public bool IsAllowed(MyDefinitionId id)
```

Determines whether a given item type is allowed go through the sorter, depending on the filter list ( [GetFilterList(List<MyInventoryItemFilter>)](Sandbox.ModAPI.Ingame.IMyConveyorSorter.GetFilterList) ) and [Mode](Sandbox.ModAPI.Ingame.IMyConveyorSorter.Mode) .

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

Whether a given item type is allowed go through the sorter

### 参数

* [MyDefinitionId](VRage.Game.MyDefinitionId) id
