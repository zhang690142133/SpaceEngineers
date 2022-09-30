← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)

### 概要

```csharp
public bool IsSameConstructAs(IMyTerminalBlock other)
```

Determines whether this block is [VRage.Game.ModAPI.GridLinkTypeEnum.Mechanical](https://docs.microsoft.com/en-us/dotnet/api/vrage.game.modapi.gridlinktypeenum.mechanical?view=netframework-4.6) connected to the other. This is any block connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.  
  
Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if blocks are on same grid, or has [VRage.Game.ModAPI.GridLinkTypeEnum.Mechanical](https://docs.microsoft.com/en-us/dotnet/api/vrage.game.modapi.gridlinktypeenum.mechanical?view=netframework-4.6) linking

### 参数

* [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock) other
