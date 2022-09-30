← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### IMySlimBlock Interface

```csharp
public interface IMySlimBlock
```

Basic block interface (PB scripting interface)

**命名空间:** [VRage.Game.ModAPI.Ingame](VRage.Game.ModAPI.Ingame)  
**Assembly:** VRage.Game.dll

#### Properties

[float AccumulatedDamage { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.AccumulatedDamage)

> Current accumlated damage, pending application

[SerializableDefinitionId BlockDefinition { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.BlockDefinition)

> Block definition ID

[float BuildIntegrity { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.BuildIntegrity)

> Build integrity (of components)

[float BuildLevelRatio { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.BuildLevelRatio)

> Ratio of BuildIntegrity and MaxIntegrity

[Vector3 ColorMaskHSV { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.ColorMaskHSV)

> Gets the color of the block

[IMyCubeGrid CubeGrid { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.CubeGrid)

> Gets the grid the slimblock is on

[float CurrentDamage { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.CurrentDamage)

> BuildIntegrity - Integrity

[float DamageRatio { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.DamageRatio)

> 

[IMyCubeBlock FatBlock { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.FatBlock)

> Gets the fatblock if there is one

[bool HasDeformation { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.HasDeformation)

> If this block is deformed (bones deformed)

[bool IsDestroyed { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.IsDestroyed)

> Gets if component stack is empty

[bool IsFullIntegrity { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.IsFullIntegrity)

> Integrity is at maximum

[bool IsFullyDismounted { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.IsFullyDismounted)

> Gets if component stack is empty

[float Mass { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.Mass)

> Block mass

[float MaxDeformation { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.MaxDeformation)

> Maximum deformation of block

[float MaxIntegrity { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.MaxIntegrity)

> The maximum integrity of block

[long OwnerId { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.OwnerId)

> Fatblock owner, if present; otherwise grid owner

[Vector3I Position { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.Position)

> Grid relative position of block

[bool ShowParts { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.ShowParts)

> Gets if sub parts are shown

[MyStringHash SkinSubtypeId { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.SkinSubtypeId)

> Gets the skin of the block

[bool StockpileAllocated { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.StockpileAllocated)

> A component stockpile has been allocated

[bool StockpileEmpty { get; }](VRage.Game.ModAPI.Ingame.IMySlimBlock.StockpileEmpty)

> The component stockpile is empty (no build components)

#### 方法

[void GetMissingComponents(Dictionary&lt;string, int&gt; addToDictionary)](VRage.Game.ModAPI.Ingame.IMySlimBlock.GetMissingComponents)

> Gets the list of missing components for this block

