← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### IMyInventoryOwner Interface

```csharp
public interface IMyInventoryOwner
```

Describes interface of object that has inventory (PB scripting interface)

**命名空间:** [VRage.Game.ModAPI.Ingame](VRage.Game.ModAPI.Ingame)  
**Assembly:** VRage.Game.dll

#### Properties

[long EntityId { get; }](VRage.Game.ModAPI.Ingame.IMyInventoryOwner.EntityId)

> Gets EntityId, which it belongs to

[bool HasInventory { get; }](VRage.Game.ModAPI.Ingame.IMyInventoryOwner.HasInventory)

> Gets whether has inventory

[int InventoryCount { get; }](VRage.Game.ModAPI.Ingame.IMyInventoryOwner.InventoryCount)

> Gets amount of inventories

[bool UseConveyorSystem { get; set; }](VRage.Game.ModAPI.Ingame.IMyInventoryOwner.UseConveyorSystem)

> Gets or sets if that inventory can interact with

#### 方法

[IMyInventory GetInventory(int index)](VRage.Game.ModAPI.Ingame.IMyInventoryOwner.GetInventory)

> Gets inventory by index

