← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector4](VRageMath.Vector4)

### 概要

```csharp
public static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2)
```

Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 4D triangle.

### 返回

[Vector4](VRageMath.Vector4)

### 参数

* [Vector4](VRageMath.Vector4) value1
* [Vector4](VRageMath.Vector4) value2
* [Vector4](VRageMath.Vector4) value3
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount1
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount2
### 概要

```csharp
public static void Barycentric(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, float amount1, float amount2, out Vector4 result)
```

Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in Barycentric (areal) coordinates relative to a 4D triangle.

### 参数

* [Vector4](VRageMath.Vector4) value1
* [Vector4](VRageMath.Vector4) value2
* [Vector4](VRageMath.Vector4) value3
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount1
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount2
* [Vector4](VRageMath.Vector4) result
