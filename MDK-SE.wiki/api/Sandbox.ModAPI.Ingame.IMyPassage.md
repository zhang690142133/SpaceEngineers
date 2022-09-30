← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### IMyPassage Interface

```csharp
public interface IMyPassage: IMyCubeBlock, IMyEntity
```

Describes passage block (PB scripting interface)

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

**Implements:**  
* [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)

#### Properties

[SerializableDefinitionId BlockDefinition { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.BlockDefinition)

> Gets definition.Id assigned to this block  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[bool Closed { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.Closed)

> True if the block has been removed from the world.  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[MyEntityComponentContainer Components { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.Components)

> Gets blocks component logic container  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[IMyCubeGrid CubeGrid { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.CubeGrid)

> Grid in which the block is placed  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[string DefinitionDisplayNameText { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.DefinitionDisplayNameText)

> Definition name  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[float DisassembleRatio { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.DisassembleRatio)

> Is set in definition Ratio at which is the block disassembled (grinding) Bigger values - longer grinding  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[string DisplayName { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.DisplayName)

> Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock.DisplayNameText)   
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[string DisplayNameText { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.DisplayNameText)

> Translated block name  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[long EntityId { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.EntityId)

> Id of entity  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[bool HasInventory { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.HasInventory)

> Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[int InventoryCount { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.InventoryCount)

> Returns the count of the number of inventories this entity has.  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[bool IsBeingHacked { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.IsBeingHacked)

> Hacking of the block is in progress  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[bool IsFunctional { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.IsFunctional)

> Gets if integrity is above breaking threshold  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[bool IsWorking { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.IsWorking)

> True if block is able to do its work depening on block type (is functional, powered, enabled, etc...)  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[float Mass { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.Mass)

> Block mass  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[Vector3I Max { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.Max)

> Maximum coordinates of grid cells occupied by this block  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[Vector3I Min { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.Min)

> Minimum coordinates of grid cells occupied by this block  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[string Name { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.Name)

> Some entities can have uniq name, and game can find them by name [VRage.ModAPI.IMyEntities.TryGetEntityByName(System.String,VRage.ModAPI.IMyEntity@)](https://docs.microsoft.com/en-us/dotnet/api/vrage.modapi.imyentities.trygetentitybyname(system.string,vrage.modapi.imyentity@)?view=netframework-4.6)   
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[int NumberInGrid { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.NumberInGrid)

> Order in which were the blocks of same type added to grid Used in default display name  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[MyBlockOrientation Orientation { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.Orientation)

> Returns block orientation in base 6 directions  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[long OwnerId { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.OwnerId)

> IdentityId of player owning block (not steam Id)  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[Vector3I Position { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.Position)

> Position in grid coordinates  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[BoundingBoxD WorldAABB { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.WorldAABB)

> Gets world axis-aligned bounding box  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[BoundingBoxD WorldAABBHr { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.WorldAABBHr)

> Gets world axis-aligned bounding box  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[MatrixD WorldMatrix { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.WorldMatrix)

> Gets world matrix of this entity  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[BoundingSphereD WorldVolume { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.WorldVolume)

> Gets bounding sphere of this entity  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[BoundingSphereD WorldVolumeHr { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.WorldVolumeHr)

> Gets bounding sphere of this entity  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

#### 方法

[IMyInventory GetInventory()](VRage.Game.ModAPI.Ingame.IMyEntity.GetInventory)

> Simply get the MyInventoryBase component stored in this entity.  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[IMyInventory GetInventory(int index)](VRage.Game.ModAPI.Ingame.IMyEntity.GetInventory)

> Search for inventory component with maching index.  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[string GetOwnerFactionTag()](VRage.Game.ModAPI.Ingame.IMyCubeBlock.GetOwnerFactionTag)

> Tag of faction owning block  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[Vector3D GetPosition()](VRage.Game.ModAPI.Ingame.IMyEntity.GetPosition)

> Gets position in world coordinates  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[MyRelationsBetweenPlayerAndBlock GetUserRelationToOwner(long playerId, MyRelationsBetweenPlayerAndBlock defaultNoUser = MyRelationsBetweenPlayerAndBlock.NoOwnership)](VRage.Game.ModAPI.Ingame.IMyCubeBlock.GetUserRelationToOwner)

> Gets relation to owner of block  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[MyRelationsBetweenPlayerAndBlock GetPlayerRelationToOwner()](VRage.Game.ModAPI.Ingame.IMyCubeBlock.GetPlayerRelationToOwner)

> _**Obsolete:** GetPlayerRelationToOwner() is useless ingame. Mods should use the one in ModAPI.IMyCubeBlock_  
>   
> Relation of local player to the block Should not be called on Dedicated Server.  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[void UpdateIsWorking()](VRage.Game.ModAPI.Ingame.IMyCubeBlock.UpdateIsWorking)

> _**Obsolete**_  
>   
> Force refresh working state. Call if you change block state that could affect its working status.  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[void UpdateVisual()](VRage.Game.ModAPI.Ingame.IMyCubeBlock.UpdateVisual)

> _**Obsolete**_  
>   
> Updates block visuals (ie. block emissivity)  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

