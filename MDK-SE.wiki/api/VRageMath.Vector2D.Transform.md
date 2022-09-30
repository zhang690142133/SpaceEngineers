← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector2D](VRageMath.Vector2D)

### 概要

```csharp
public static Vector2D Transform(Vector2D position, Matrix matrix)
```

Transforms the vector (x, y, 0, 1) by the specified matrix.

### 返回

[Vector2D](VRageMath.Vector2D)

### 参数

* [Vector2D](VRageMath.Vector2D) position
* [Matrix](VRageMath.Matrix) matrix
### 概要

```csharp
public static void Transform(ref Vector2D position, ref Matrix matrix, out Vector2D result)
```

Transforms a Vector2D by the given Matrix.

### 参数

* [Vector2D](VRageMath.Vector2D) position
* [Matrix](VRageMath.Matrix) matrix
* [Vector2D](VRageMath.Vector2D) result
### 概要

```csharp
public static Vector2D Transform(Vector2D value, Quaternion rotation)
```

Transforms a single Vector2D, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

### 返回

[Vector2D](VRageMath.Vector2D)

### 参数

* [Vector2D](VRageMath.Vector2D) value
* [Quaternion](VRageMath.Quaternion) rotation
### 概要

```csharp
public static void Transform(ref Vector2D value, ref Quaternion rotation, out Vector2D result)
```

Transforms a Vector2D, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

### 参数

* [Vector2D](VRageMath.Vector2D) value
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector2D](VRageMath.Vector2D) result
### 概要

```csharp
public static void Transform(Vector2D[] sourceArray, ref Matrix matrix, Vector2D[] destinationArray)
```

Transforms an array of Vector2s by a specified Matrix.

### 参数

* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) sourceArray
* [Matrix](VRageMath.Matrix) matrix
* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) destinationArray
### 概要

```csharp
public static void Transform(Vector2D[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2D[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector2s by a specified Matrix and places the results in a specified range in a destination array.

### 参数

* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Matrix](VRageMath.Matrix) matrix
* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
### 概要

```csharp
public static void Transform(Vector2D[] sourceArray, ref Quaternion rotation, Vector2D[] destinationArray)
```

Transforms an array of Vector2s by a specified Quaternion.

### 参数

* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) sourceArray
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) destinationArray
### 概要

```csharp
public static void Transform(Vector2D[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector2D[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector2s by a specified Quaternion and places the results in a specified range in a destination array.

### 参数

* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector2D&#91&#93;](VRageMath.Vector2D&#91&#93;) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
