← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyTerminalAccessScope Enum

```csharp
public enum MyTerminalAccessScope
```

Determines how [CanAccess(IMyTerminalBlock, MyTerminalAccessScope = MyTerminalAccessScope.All)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem.CanAccess) limits its access check.

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

#### Fields

MyTerminalAccessScope All

> Checks for access over the entire grid terminal system, no matter how the block is connected.

MyTerminalAccessScope Construct

> Checks for access only within the current construct. This is any block connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct. Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way.

MyTerminalAccessScope Grid

> Checks for access only for blocks on the same grid as the programmable block.

