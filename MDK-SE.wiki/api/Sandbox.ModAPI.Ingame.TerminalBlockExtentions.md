← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### TerminalBlockExtentions Class

```csharp
public abstract sealed class TerminalBlockExtentions
```

Class having some sugar extensions. Written by Kalvin Osborne, AKA Night Lone.

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

#### 方法

[static void ApplyAction(this IMyTerminalBlock block, string actionName)](Sandbox.ModAPI.Ingame.TerminalBlockExtentions.ApplyAction)

> Finds action by [GetActionWithName(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.GetActionWithName) and calls [Apply(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalAction.Apply) 

[static void ApplyAction(this IMyTerminalBlock block, string actionName, List&lt;TerminalActionParameter&gt; parameters)](Sandbox.ModAPI.Ingame.TerminalBlockExtentions.ApplyAction)

> Finds action by [GetActionWithName(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock.GetActionWithName) and calls [Apply(IMyCubeBlock, ListReader<TerminalActionParameter>)](Sandbox.ModAPI.Interfaces.ITerminalAction.Apply) 

[static long GetId(this IMyTerminalBlock block)](Sandbox.ModAPI.Ingame.TerminalBlockExtentions.GetId)

> Get EntityId of block

[static bool HasAction(this IMyTerminalBlock block, string actionName)](Sandbox.ModAPI.Ingame.TerminalBlockExtentions.HasAction)

> Searches for terminal action with name

[static IMyInventory GetInventory(this IMyTerminalBlock block, int index)](Sandbox.ModAPI.Ingame.TerminalBlockExtentions.GetInventory)

> _**Obsolete:** Use the GetInventoryBase method._  
>   
> Obsolete

[static int GetInventoryCount(this IMyTerminalBlock block)](Sandbox.ModAPI.Ingame.TerminalBlockExtentions.GetInventoryCount)

> _**Obsolete:** Use the InventoryCount property._  
>   
> Obsolete

[static bool GetUseConveyorSystem(this IMyTerminalBlock block)](Sandbox.ModAPI.Ingame.TerminalBlockExtentions.GetUseConveyorSystem)

> _**Obsolete:** Use the blocks themselves, this method is no longer reliable_  
>   
> Obsolete

[static bool HasInventory(this IMyTerminalBlock block)](Sandbox.ModAPI.Ingame.TerminalBlockExtentions.HasInventory)

> _**Obsolete:** Use the HasInventory property._  
>   
> Obsolete

[static void SetUseConveyorSystem(this IMyTerminalBlock block, bool use)](Sandbox.ModAPI.Ingame.TerminalBlockExtentions.SetUseConveyorSystem)

> _**Obsolete:** Use the blocks themselves, this method is no longer reliable_  
>   
> Obsolete

