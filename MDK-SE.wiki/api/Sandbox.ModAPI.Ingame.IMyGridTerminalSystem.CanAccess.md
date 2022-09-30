← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)

### 概要

```csharp
public bool CanAccess(IMyTerminalBlock block, MyTerminalAccessScope scope = MyTerminalAccessScope.All)
```

Checks if the grid terminal system can still access the given [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock) . A block is no longer accessible if it's destroyed, detached, it's ownership has changed or is otherwise disconnected from this grid terminal system.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock) block
* [MyTerminalAccessScope](Sandbox.ModAPI.Ingame.MyTerminalAccessScope) scope
### 概要

```csharp
public bool CanAccess(IMyCubeGrid grid, MyTerminalAccessScope scope = MyTerminalAccessScope.All)
```

Checks if the grid terminal system can still access the given [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid) . A grid is no longer accessible if it's destroyed, detached, it's ownership has changed or is otherwise disconnected from this grid terminal system.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

False if grid is`null`, closed or you can't access that grid

### 参数

* [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid) grid
* [MyTerminalAccessScope](Sandbox.ModAPI.Ingame.MyTerminalAccessScope) scope
