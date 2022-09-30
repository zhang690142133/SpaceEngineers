← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyCameraBlock](Sandbox.ModAPI.Ingame.IMyCameraBlock)

### 概要

```csharp
public bool CanScan(double distance)
```

Checks if the camera can scan the given distance.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

true if camera can scan

### 参数

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) distance
### 概要

```csharp
public bool CanScan(double distance, Vector3D direction)
```

Checks if the camera can scan to the given direction and distance (in camera local space).

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

true if camera can scan

### 参数

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) distance
* [Vector3D](VRageMath.Vector3D) direction
### 概要

```csharp
public bool CanScan(Vector3D target)
```

Checks if the camera can scan to the given target

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

true if camera can scan

### 参数

* [Vector3D](VRageMath.Vector3D) target
