← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### IMyInventory Interface

```csharp
public interface IMyInventory
```

Describes inventory interface (PB scripting interface)

**命名空间:** [VRage.Game.ModAPI.Ingame](VRage.Game.ModAPI.Ingame)  
**Assembly:** VRage.Game.dll

#### Properties

[MyFixedPoint CurrentMass { get; }](VRage.Game.ModAPI.Ingame.IMyInventory.CurrentMass)

> Returns total mass of items inside this inventory in Kg.

[MyFixedPoint CurrentVolume { get; }](VRage.Game.ModAPI.Ingame.IMyInventory.CurrentVolume)

> Returns total volume of items inside this inventory in m^3.

[bool IsFull { get; }](VRage.Game.ModAPI.Ingame.IMyInventory.IsFull)

> Determines if inventory is absolutely full.

[int ItemCount { get; }](VRage.Game.ModAPI.Ingame.IMyInventory.ItemCount)

> Returns number of occupied inventory slots.

[MyFixedPoint MaxVolume { get; }](VRage.Game.ModAPI.Ingame.IMyInventory.MaxVolume)

> Returns maximum volume of items this inventory can contain in m^3.

[IMyEntity Owner { get; }](VRage.Game.ModAPI.Ingame.IMyInventory.Owner)

> Returns entity this inventory belongs to.

#### 方法

[bool CanItemsBeAdded(MyFixedPoint amount, MyItemType itemType)](VRage.Game.ModAPI.Ingame.IMyInventory.CanItemsBeAdded)

> Determines if given amount of items fits into this inventory on top of existing items.

[bool CanTransferItemTo(IMyInventory otherInventory, MyItemType itemType)](VRage.Game.ModAPI.Ingame.IMyInventory.CanTransferItemTo)

> Determines if there is working conveyor connection for item of give type to be transferred to other inventory.

[bool ContainItems(MyFixedPoint amount, MyItemType itemType)](VRage.Game.ModAPI.Ingame.IMyInventory.ContainItems)

> Determines if there is at least given amount of items of given type contained inside this inventory.

[MyInventoryItem? FindItem(MyItemType itemType)](VRage.Game.ModAPI.Ingame.IMyInventory.FindItem)

> Tries to find an item of given type inside this inventory.

[void GetAcceptedItems(List&lt;MyItemType&gt; itemsTypes, Func&lt;MyItemType, bool&gt; filter = null)](VRage.Game.ModAPI.Ingame.IMyInventory.GetAcceptedItems)

> Returns all items this inventory accepts.

[MyFixedPoint GetItemAmount(MyItemType itemType)](VRage.Game.ModAPI.Ingame.IMyInventory.GetItemAmount)

> Sums up total amount of items of given type contained inside this inventory.

[MyInventoryItem? GetItemAt(int index)](VRage.Game.ModAPI.Ingame.IMyInventory.GetItemAt)

> Returns info about item at give position.

[MyInventoryItem? GetItemByID(uint id)](VRage.Game.ModAPI.Ingame.IMyInventory.GetItemByID)

> Returns info about item contained inside this inventory.

[void GetItems(List&lt;MyInventoryItem&gt; items, Func&lt;MyInventoryItem, bool&gt; filter = null)](VRage.Game.ModAPI.Ingame.IMyInventory.GetItems)

> Collects all items present inside this inventory and returns snapshot of the current inventory state.

[bool IsConnectedTo(IMyInventory otherInventory)](VRage.Game.ModAPI.Ingame.IMyInventory.IsConnectedTo)

> Checks if two inventories are connected.

[bool IsItemAt(int position)](VRage.Game.ModAPI.Ingame.IMyInventory.IsItemAt)

> Determines if there is any item on given inventory slot.

[bool TransferItemFrom(IMyInventory sourceInventory, MyInventoryItem item, MyFixedPoint? amount = default)](VRage.Game.ModAPI.Ingame.IMyInventory.TransferItemFrom)

> Attempts to transfer item from one inventory to another.

[bool TransferItemFrom(IMyInventory sourceInventory, int sourceItemIndex, int? targetItemIndex = default, bool? stackIfPossible = default, MyFixedPoint? amount = default)](VRage.Game.ModAPI.Ingame.IMyInventory.TransferItemFrom)

> Attempts to transfer item from one inventory to another.

[bool TransferItemTo(IMyInventory dstInventory, MyInventoryItem item, MyFixedPoint? amount = default)](VRage.Game.ModAPI.Ingame.IMyInventory.TransferItemTo)

> Attempts to transfer item from one inventory to another.

[bool TransferItemTo(IMyInventory dst, int sourceItemIndex, int? targetItemIndex = default, bool? stackIfPossible = default, MyFixedPoint? amount = default)](VRage.Game.ModAPI.Ingame.IMyInventory.TransferItemTo)

> Attempts to transfer item from one inventory to another.

