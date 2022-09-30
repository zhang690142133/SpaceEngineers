← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### IMyAssembler Interface

```csharp
public interface IMyAssembler: IMyProductionBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

Describes assembler block (PB scripting interface)

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

**Implements:**  
* [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)  
* [IMyFunctionalBlock](Sandbox.ModAPI.Ingame.IMyFunctionalBlock)  
* [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)  
* [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)

**Type Definitions:**  
* MyObjectBuilder_Assembler/BasicAssembler  
* MyObjectBuilder_Assembler/LargeAssembler  
* MyObjectBuilder_Assembler/LargeAssemblerIndustrial

#### Properties

[bool CooperativeMode { get; set; }](Sandbox.ModAPI.Ingame.IMyAssembler.CooperativeMode)

> Gets or sets whether this assembler should cooperate with other assemblers by adopting parts of their work queue.

[float CurrentProgress { get; }](Sandbox.ModAPI.Ingame.IMyAssembler.CurrentProgress)

> Gets the progress for the item currently in production.

[MyAssemblerMode Mode { get; set; }](Sandbox.ModAPI.Ingame.IMyAssembler.Mode)

> Gets or sets the current work mode of this assembly, whether it's assembling or disassembling.

[bool Repeating { get; set; }](Sandbox.ModAPI.Ingame.IMyAssembler.Repeating)

> Gets or sets whether this assembler should be perpetually repeating its work queue.

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

[string CustomData { get; set; }](Sandbox.ModAPI.Ingame.IMyTerminalBlock.CustomData)

> Gets or sets the Custom Data string. NOTE: Only use this for user input. For storing large mod configs, create your own MyModStorageComponent  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[string CustomInfo { get; }](Sandbox.ModAPI.Ingame.IMyTerminalBlock.CustomInfo)

> Gets information about block status (available from mods) [Sandbox.ModAPI.IMyTerminalBlock.AppendingCustomInfo](https://docs.microsoft.com/en-us/dotnet/api/sandbox.modapi.imyterminalblock.appendingcustominfo?view=netframework-4.6)  [Sandbox.ModAPI.IMyTerminalBlock.RefreshCustomInfo](https://docs.microsoft.com/en-us/dotnet/api/sandbox.modapi.imyterminalblock.refreshcustominfo?view=netframework-4.6) .  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[string CustomName { get; set; }](Sandbox.ModAPI.Ingame.IMyTerminalBlock.CustomName)

> Gets or sets how block is named in Terminal menu  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[string CustomNameWithFaction { get; }](Sandbox.ModAPI.Ingame.IMyTerminalBlock.CustomNameWithFaction)

> Gets or sets how block is named in Terminal menu. Work only for Cockpit, LaserAntenna RadioAntenna, SpaceBall, Beacon  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[string DefinitionDisplayNameText { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.DefinitionDisplayNameText)

> Definition name  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[string DetailedInfo { get; }](Sandbox.ModAPI.Ingame.IMyTerminalBlock.DetailedInfo)

> Gets information about block status. In Control panel bottom right text  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

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

[bool Enabled { get; set; }](Sandbox.ModAPI.Ingame.IMyFunctionalBlock.Enabled)

> Represents terminal gui toggle. Gets or sets if block is Enabled  
>   
> _Inherited from [IMyFunctionalBlock](Sandbox.ModAPI.Ingame.IMyFunctionalBlock)_

[long EntityId { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.EntityId)

> Id of entity  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[bool HasInventory { get; }](VRage.Game.ModAPI.Ingame.IMyEntity.HasInventory)

> Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.  
>   
> _Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_

[IMyInventory InputInventory { get; }](Sandbox.ModAPI.Ingame.IMyProductionBlock.InputInventory)

> Gets the input inventory.  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

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

[bool IsProducing { get; }](Sandbox.ModAPI.Ingame.IMyProductionBlock.IsProducing)

> Gets whether block is currently producing.  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[bool IsQueueEmpty { get; }](Sandbox.ModAPI.Ingame.IMyProductionBlock.IsQueueEmpty)

> Gets whether production queue is empty.  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

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

[uint NextItemId { get; }](Sandbox.ModAPI.Ingame.IMyProductionBlock.NextItemId)

> Gets the queue item ID of the next item to be produced.  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[int NumberInGrid { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.NumberInGrid)

> Order in which were the blocks of same type added to grid Used in default display name  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[MyBlockOrientation Orientation { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.Orientation)

> Returns block orientation in base 6 directions  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[IMyInventory OutputInventory { get; }](Sandbox.ModAPI.Ingame.IMyProductionBlock.OutputInventory)

> Gets the output inventory.  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[long OwnerId { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.OwnerId)

> IdentityId of player owning block (not steam Id)  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[Vector3I Position { get; }](VRage.Game.ModAPI.Ingame.IMyCubeBlock.Position)

> Position in grid coordinates  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[bool ShowInInventory { get; set; }](Sandbox.ModAPI.Ingame.IMyTerminalBlock.ShowInInventory)

> Represent terminal gui toggle `Show block in Inventory Screen`. Gets or sets its value  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[bool ShowInTerminal { get; set; }](Sandbox.ModAPI.Ingame.IMyTerminalBlock.ShowInTerminal)

> Represent terminal gui toggle `Show block in terminal`. Gets or sets its value  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[bool ShowInToolbarConfig { get; set; }](Sandbox.ModAPI.Ingame.IMyTerminalBlock.ShowInToolbarConfig)

> Represent terminal gui toggle `Show in toolbar config`. Gets or sets its value  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[bool ShowOnHUD { get; set; }](Sandbox.ModAPI.Ingame.IMyTerminalBlock.ShowOnHUD)

> Represent terminal gui toggle `Show On HUD`. Gets or sets its value  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[bool UseConveyorSystem { get; set; }](Sandbox.ModAPI.Ingame.IMyProductionBlock.UseConveyorSystem)

> Gets or sets whether this device should use the conveyor system to retrieve and store items.  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

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

[bool DisassembleEnabled { get; }](Sandbox.ModAPI.Ingame.IMyAssembler.DisassembleEnabled)

> _**Obsolete:** Use the Mode property_  
>   
> Gets whether this assembler has disassemble mode enabled

#### 方法

[void AddQueueItem(MyDefinitionId blueprint, MyFixedPoint amount)](Sandbox.ModAPI.Ingame.IMyProductionBlock.AddQueueItem)

> Adds a blueprint to the production queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[void AddQueueItem(MyDefinitionId blueprint, decimal amount)](Sandbox.ModAPI.Ingame.IMyProductionBlock.AddQueueItem)

> Adds a blueprint to the production queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[void AddQueueItem(MyDefinitionId blueprint, double amount)](Sandbox.ModAPI.Ingame.IMyProductionBlock.AddQueueItem)

> Adds a blueprint to the production queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[bool CanUseBlueprint(MyDefinitionId blueprint)](Sandbox.ModAPI.Ingame.IMyProductionBlock.CanUseBlueprint)

> Can this production block produce this blueprint?  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[void ClearQueue()](Sandbox.ModAPI.Ingame.IMyProductionBlock.ClearQueue)

> Clears the Queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[void GetActions(List&lt;ITerminalAction&gt; resultList, Func&lt;ITerminalAction, bool&gt; collect = null)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.GetActions)

> Get all terminal actions available for block  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[ITerminalAction GetActionWithName(string name)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.GetActionWithName)

> Get first found terminal action with name  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

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

[void GetProperties(List&lt;ITerminalProperty&gt; resultList, Func&lt;ITerminalProperty, bool&gt; collect = null)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.GetProperties)

> Get all terminal actions available for block.  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[ITerminalProperty GetProperty(string id)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.GetProperty)

> Finds terminal property with provided id  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[void GetQueue(List&lt;MyProductionItem&gt; items)](Sandbox.ModAPI.Ingame.IMyProductionBlock.GetQueue)

> Gets the current production queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[MyRelationsBetweenPlayerAndBlock GetUserRelationToOwner(long playerId, MyRelationsBetweenPlayerAndBlock defaultNoUser = MyRelationsBetweenPlayerAndBlock.NoOwnership)](VRage.Game.ModAPI.Ingame.IMyCubeBlock.GetUserRelationToOwner)

> Gets relation to owner of block  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[bool HasLocalPlayerAccess()](Sandbox.ModAPI.Ingame.IMyTerminalBlock.HasLocalPlayerAccess)

> Returns if local player can use block. Executes [HasPlayerAccess(long, MyRelationsBetweenPlayerAndBlock = MyRelationsBetweenPlayerAndBlock.NoOwnership)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.HasPlayerAccess) with local player identityId. On Dedicated Server as identityId it is using 0 as playerId  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[bool HasPlayerAccess(long playerId, MyRelationsBetweenPlayerAndBlock defaultNoUser = MyRelationsBetweenPlayerAndBlock.NoOwnership)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.HasPlayerAccess)

> Returns if local player can use block. It is also checking for admin access.  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[void InsertQueueItem(int idx, MyDefinitionId blueprint, MyFixedPoint amount)](Sandbox.ModAPI.Ingame.IMyProductionBlock.InsertQueueItem)

> Inserts a blueprint into the production queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[void InsertQueueItem(int idx, MyDefinitionId blueprint, decimal amount)](Sandbox.ModAPI.Ingame.IMyProductionBlock.InsertQueueItem)

> Inserts a blueprint into the production queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[void InsertQueueItem(int idx, MyDefinitionId blueprint, double amount)](Sandbox.ModAPI.Ingame.IMyProductionBlock.InsertQueueItem)

> Inserts a blueprint into the production queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[bool IsSameConstructAs(IMyTerminalBlock other)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.IsSameConstructAs)

> Determines whether this block is [VRage.Game.ModAPI.GridLinkTypeEnum.Mechanical](https://docs.microsoft.com/en-us/dotnet/api/vrage.game.modapi.gridlinktypeenum.mechanical?view=netframework-4.6) connected to the other. This is any block connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.    
>     
> Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[void MoveQueueItemRequest(uint queueItemId, int targetIdx)](Sandbox.ModAPI.Ingame.IMyProductionBlock.MoveQueueItemRequest)

> Moves an item in the queue to a target position in the queue.  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[void RemoveQueueItem(int idx, MyFixedPoint amount)](Sandbox.ModAPI.Ingame.IMyProductionBlock.RemoveQueueItem)

> Removes an item from the queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[void RemoveQueueItem(int idx, decimal amount)](Sandbox.ModAPI.Ingame.IMyProductionBlock.RemoveQueueItem)

> Removes an item from the queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[void RemoveQueueItem(int idx, double amount)](Sandbox.ModAPI.Ingame.IMyProductionBlock.RemoveQueueItem)

> Removes an item from the queue  
>   
> _Inherited from [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)_

[void SearchActionsOfName(string name, List&lt;ITerminalAction&gt; resultList, Func&lt;ITerminalAction, bool&gt; collect = null)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.SearchActionsOfName)

> Get all terminal actions available for block. NOTE: First called `    
>     
> ` and then `    
>     
> ` check  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[MyRelationsBetweenPlayerAndBlock GetPlayerRelationToOwner()](VRage.Game.ModAPI.Ingame.IMyCubeBlock.GetPlayerRelationToOwner)

> _**Obsolete:** GetPlayerRelationToOwner() is useless ingame. Mods should use the one in ModAPI.IMyCubeBlock_  
>   
> Relation of local player to the block Should not be called on Dedicated Server.  
>   
> _Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_

[void RequestEnable(bool enable)](Sandbox.ModAPI.Ingame.IMyFunctionalBlock.RequestEnable)

> _**Obsolete:** Use the setter of Enabled_  
>   
> Obsolete  
>   
> _Inherited from [IMyFunctionalBlock](Sandbox.ModAPI.Ingame.IMyFunctionalBlock)_

[void SetCustomName(string text)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.SetCustomName)

> _**Obsolete:** Use the setter of Customname_  
>   
> Obsolete  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

[void SetCustomName(StringBuilder text)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.SetCustomName)

> _**Obsolete:** Use the setter of Customname_  
>   
> Obsolete  
>   
> _Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_

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

