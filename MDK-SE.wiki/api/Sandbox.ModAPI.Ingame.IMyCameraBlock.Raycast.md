← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyCameraBlock](Sandbox.ModAPI.Ingame.IMyCameraBlock)

### 概要

```csharp
public MyDetectedEntityInfo Raycast(double distance, float pitch = 0, float yaw = 0)
```

Does a raycast in the direction the camera is facing.

### 返回

[MyDetectedEntityInfo](Sandbox.ModAPI.Ingame.MyDetectedEntityInfo)

Empty if distance or angle are out of bounds.

### 参数

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) distance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) pitch
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) yaw
### 概要

```csharp
public MyDetectedEntityInfo Raycast(Vector3D targetPos)
```

Does a raycast to the specific target point.

### 返回

[MyDetectedEntityInfo](Sandbox.ModAPI.Ingame.MyDetectedEntityInfo)

Empty if distance or angle are out of bounds.

### 参数

* [Vector3D](VRageMath.Vector3D) targetPos
### 概要

```csharp
public MyDetectedEntityInfo Raycast(double distance, Vector3D targetDirection)
```

Does a raycast in the given direction (in camera local space).

### 返回

[MyDetectedEntityInfo](Sandbox.ModAPI.Ingame.MyDetectedEntityInfo)

Empty if distance or angle are out of bounds.

### 参数

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) distance
* [Vector3D](VRageMath.Vector3D) targetDirection
