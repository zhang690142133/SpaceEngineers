← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector2](VRageMath.Vector2)

### 概要

```csharp
public static Vector2 Barycentric(Vector2 value1, Vector2 value2, Vector2 value3, float amount1, float amount2)
```

Returns a Vector2 containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

### 返回

[Vector2](VRageMath.Vector2)

### 参数

* [Vector2](VRageMath.Vector2) value1
* [Vector2](VRageMath.Vector2) value2
* [Vector2](VRageMath.Vector2) value3
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount1
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount2
### 概要

```csharp
public static void Barycentric(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, float amount1, float amount2, out Vector2 result)
```

Returns a Vector2 containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

### 参数

* [Vector2](VRageMath.Vector2) value1
* [Vector2](VRageMath.Vector2) value2
* [Vector2](VRageMath.Vector2) value3
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount1
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount2
* [Vector2](VRageMath.Vector2) result
