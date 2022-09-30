← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### IMyCubeGrid Interface

```csharp
public interface IMyCubeGrid: IMyEntity
```

Grid interface

**命名空间:** [VRage.Game.ModAPI.Ingame](VRage.Game.ModAPI.Ingame)  
**Assembly:** VRage.Game.dll

**Implements:**  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)

#### Properties

[string CustomName { get; set; }](VRage.Game.ModAPI.Ingame.IMyCubeGrid.CustomName)

> Getter and setter for display name of the grid (as seen in Info terminal tab)

[float GridSize { get; }](VRage.Game.ModAPI.Ingame.IMyCubeGrid.GridSize)

> Getter of grid size in meters

[MyCubeSize GridSizeEnum { get; }](VRage.Game.ModAPI.Ingame.IMyCubeGrid.GridSizeEnum)

> Getter for grid size enum

[bool IsStatic { get; }](VRage.Game.ModAPI.Ingame.IMyCubeGrid.IsStatic)

> Determines if the grid is static (unmoveable)

[Vector3I Max { get; }](VRage.Game.ModAPI.Ingame.IMyCubeGrid.Max)

> Maximum coordinates of blocks in grid

[Vector3I Min { get; }](VRage.Game.ModAPI.Ingame.IMyCubeGrid.Min)

> Minimum coordinates of blocks in grid

[bool Closed { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.Closed)

> True if the block has been removed from the world.  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[MyEntityComponentContainer Components { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.Components)

> Gets blocks component logic container  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[string DisplayName { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.DisplayName)

> Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock.DisplayNameText)   
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

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

[string Name { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.Name)

> Some entities can have uniq name, and game can find them by name [VRage.ModAPI.IMyEntities.TryGetEntityByName(System.String,VRage.ModAPI.IMyEntity@)](https://docs.microsoft.com/en-us/dotnet/api/vrage.modapi.imyentities.trygetentitybyname(system.string,vrage.modapi.imyentity@)?view=netframework-4.6)   
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

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

[bool CubeExists(Vector3I pos)](VRage.Game.ModAPI.Ingame.IMyCubeGrid.CubeExists)

> Returns true if there is any block occupying given position

[IMySlimBlock GetCubeBlock(Vector3I pos)](VRage.Game.ModAPI.Ingame.IMyCubeGrid.GetCubeBlock)

> Get cube block at given position

[Vector3D GridIntegerToWorld(Vector3I gridCoords)](VRage.Game.ModAPI.Ingame.IMyCubeGrid.GridIntegerToWorld)

> Converts grid coordinates to world space

[bool IsSameConstructAs(IMyCubeGrid other)](VRage.Game.ModAPI.Ingame.IMyCubeGrid.IsSameConstructAs)

> Determines whether this grid is [VRage.Game.ModAPI.GridLinkTypeEnum.Mechanical](https://docs.microsoft.com/en-us/dotnet/api/vrage.game.modapi.gridlinktypeenum.mechanical?view=netframework-4.6) connected to the other. This is any grid connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.    
>     
> Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.

[Vector3I WorldToGridInteger(Vector3D coords)](VRage.Game.ModAPI.Ingame.IMyCubeGrid.WorldToGridInteger)

> Converts world coordinates to grid space cell coordinates

[IMyInventory GetInventory()](VRage.Game.ModAPI.Ingame.IMyEntity.GetInventory)

> Simply get the MyInventoryBase component stored in this entity.  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[IMyInventory GetInventory(int index)](VRage.Game.ModAPI.Ingame.IMyEntity.GetInventory)

> Search for inventory component with maching index.  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[Vector3D GetPosition()](VRage.Game.ModAPI.Ingame.IMyEntity.GetPosition)

> Gets position in world coordinates  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

