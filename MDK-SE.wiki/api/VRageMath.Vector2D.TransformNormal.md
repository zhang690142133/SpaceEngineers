← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector2D](VRageMath.Vector2D)

### 概要

```csharp
public static Vector2D TransformNormal(Vector2D normal, Matrix matrix)
```

Transforms a 2D vector normal by a matrix.

### 返回

[Vector2D](VRageMath.Vector2D)

### 参数

* [Vector2D](VRageMath.Vector2D) normal
* [Matrix](VRageMath.Matrix) matrix
### 概要

```csharp
public static void TransformNormal(ref Vector2D normal, ref Matrix matrix, out Vector2D result)
```

Transforms a vector normal by a matrix.

### 参数

* [Vector2D](VRageMath.Vector2D) normal
* [Matrix](VRageMath.Matrix) matrix
* [Vector2D](VRageMath.Vector2D) result
### 概要

```csharp
public static void TransformNormal(Vector2D[] sourceArray, ref Matrix matrix, Vector2D[] destinationArray)
```

Transforms an array of Vector2D vector normals by a specified Matrix.

### 参数

* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) sourceArray
* [Matrix](VRageMath.Matrix) matrix
* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) destinationArray
### 概要

```csharp
public static void TransformNormal(Vector2D[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2D[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector2D vector normals by a specified Matrix and places the results in a specified range in a destination array.

### 参数

* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Matrix](VRageMath.Matrix) matrix
* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
