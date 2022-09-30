← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)

### 概要

```csharp
public bool HasPlayerAccess(long playerId, MyRelationsBetweenPlayerAndBlock defaultNoUser = MyRelationsBetweenPlayerAndBlock.NoOwnership)
```

Returns if local player can use block. It is also checking for admin access.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

Can player access block or not

### 参数

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) playerId
* [MyRelationsBetweenPlayerAndBlock](VRage.Game.MyRelationsBetweenPlayerAndBlock) defaultNoUser
