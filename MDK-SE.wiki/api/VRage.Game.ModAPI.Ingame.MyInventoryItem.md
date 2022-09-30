← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyInventoryItem Struct

```csharp
public struct MyInventoryItem: IComparable<MyInventoryItem>, IEquatable<MyInventoryItem>
```

Snapshot of inventory item at the moment of query. Not updated afterwards!

**命名空间:** [VRage.Game.ModAPI.Ingame](VRage.Game.ModAPI.Ingame)  
**Assembly:** VRage.Game.dll

**Implements:**  
* [IComparable&lt;MyInventoryItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netframework-4.6)  
* [IEquatable&lt;MyInventoryItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[MyFixedPoint Amount](VRage.Game.ModAPI.Ingame.MyInventoryItem.Amount)

> Amount of stacked items. Kg or count, based on item type.

[uint ItemId](VRage.Game.ModAPI.Ingame.MyInventoryItem.ItemId)

> Id of item, unique within a single inventory.

[MyItemType Type](VRage.Game.ModAPI.Ingame.MyInventoryItem.Type)

> Type of inventory item.

#### Constructors

[MyInventoryItem(MyItemType type, uint itemId, MyFixedPoint amount)](VRage.Game.ModAPI.Ingame.MyInventoryItem..ctor)

> 

#### 方法

[int CompareTo(MyInventoryItem other)](VRage.Game.ModAPI.Ingame.MyInventoryItem.CompareTo)

> 

[bool Equals(MyInventoryItem other)](VRage.Game.ModAPI.Ingame.MyInventoryItem.Equals)

> 

[bool Equals(object obj)](VRage.Game.ModAPI.Ingame.MyInventoryItem.Equals)

> 

[int GetHashCode()](VRage.Game.ModAPI.Ingame.MyInventoryItem.GetHashCode)

> 

[string ToString()](VRage.Game.ModAPI.Ingame.MyInventoryItem.ToString)

> 

