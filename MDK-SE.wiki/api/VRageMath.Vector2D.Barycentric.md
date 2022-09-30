← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector2D](VRageMath.Vector2D)

### 概要

```csharp
public static Vector2D Barycentric(Vector2D value1, Vector2D value2, Vector2D value3, double amount1, double amount2)
```

Returns a Vector2D containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

### 返回

[Vector2D](VRageMath.Vector2D)

### 参数

* [Vector2D](VRageMath.Vector2D) value1
* [Vector2D](VRageMath.Vector2D) value2
* [Vector2D](VRageMath.Vector2D) value3
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount1
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount2
### 概要

```csharp
public static void Barycentric(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, double amount1, double amount2, out Vector2D result)
```

Returns a Vector2D containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

### 参数

* [Vector2D](VRageMath.Vector2D) value1
* [Vector2D](VRageMath.Vector2D) value2
* [Vector2D](VRageMath.Vector2D) value3
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount1
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount2
* [Vector2D](VRageMath.Vector2D) result
