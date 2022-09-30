← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector2](VRageMath.Vector2)

### 概要

```csharp
public static Vector2 Transform(Vector2 position, Matrix matrix)
```

Transforms the vector (x, y, 0, 1) by the specified matrix.

### 返回

[Vector2](VRageMath.Vector2)

### 参数

* [Vector2](VRageMath.Vector2) position
* [Matrix](VRageMath.Matrix) matrix
### 概要

```csharp
public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector2 result)
```

Transforms a Vector2 by the given Matrix.

### 参数

* [Vector2](VRageMath.Vector2) position
* [Matrix](VRageMath.Matrix) matrix
* [Vector2](VRageMath.Vector2) result
### 概要

```csharp
public static Vector2 Transform(Vector2 value, Quaternion rotation)
```

Transforms a single Vector2, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

### 返回

[Vector2](VRageMath.Vector2)

### 参数

* [Vector2](VRageMath.Vector2) value
* [Quaternion](VRageMath.Quaternion) rotation
### 概要

```csharp
public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector2 result)
```

Transforms a Vector2, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

### 参数

* [Vector2](VRageMath.Vector2) value
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector2](VRageMath.Vector2) result
### 概要

```csharp
public static void Transform(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
```

Transforms an array of Vector2s by a specified Matrix.

### 参数

* [Vector2&#91&#93;](VRageMath.Vector2&#91&#93;) sourceArray
* [Matrix](VRageMath.Matrix) matrix
* [Vector2&#91&#93;](VRageMath.Vector2&#91&#93;) destinationArray
### 概要

```csharp
public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector2s by a specified Matrix and places the results in a specified range in a destination array.

### 参数

* [Vector2&#91&#93;](VRageMath.Vector2&#91&#93;) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Matrix](VRageMath.Matrix) matrix
* [Vector2&#91&#93;](VRageMath.Vector2&#91&#93;) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
### 概要

```csharp
public static void Transform(Vector2[] sourceArray, ref Quaternion rotation, Vector2[] destinationArray)
```

Transforms an array of Vector2s by a specified Quaternion.

### 参数

* [Vector2&#91&#93;](VRageMath.Vector2&#91&#93;) sourceArray
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector2&#91&#93;](VRageMath.Vector2&#91&#93;) destinationArray
### 概要

```csharp
public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector2[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector2s by a specified Quaternion and places the results in a specified range in a destination array.

### 参数

* [Vector2&#91&#93;](VRageMath.Vector2&#91&#93;) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector2&#91&#93;](VRageMath.Vector2&#91&#93;) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
