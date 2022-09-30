← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Quaternion](VRageMath.Quaternion)

### 概要

```csharp
public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
```

Interpolates between two quaternions, using spherical linear interpolation.

### 返回

[Quaternion](VRageMath.Quaternion)

### 参数

* [Quaternion](VRageMath.Quaternion) quaternion1
* [Quaternion](VRageMath.Quaternion) quaternion2
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount
### 概要

```csharp
public static void Slerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
```

Interpolates between two quaternions, using spherical linear interpolation.

### 参数

* [Quaternion](VRageMath.Quaternion) quaternion1
* [Quaternion](VRageMath.Quaternion) quaternion2
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount
* [Quaternion](VRageMath.Quaternion) result
