← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector2D](VRageMath.Vector2D)

### 概要

```csharp
public static double Dot(Vector2D value1, Vector2D value2)
```

Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a doubleing point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

### 返回

[double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6)

### 参数

* [Vector2D](VRageMath.Vector2D) value1
* [Vector2D](VRageMath.Vector2D) value2
### 概要

```csharp
public static void Dot(ref Vector2D value1, ref Vector2D value2, out double result)
```

Calculates the dot product of two vectors and writes the result to a user-specified variable. If the two vectors are unit vectors, the dot product returns a doubleing point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

### 参数

* [Vector2D](VRageMath.Vector2D) value1
* [Vector2D](VRageMath.Vector2D) value2
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) result
