← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector3D](VRageMath.Vector3D)

### 概要

```csharp
public static Vector3D Reject(Vector3D vector, Vector3D direction)
```

Returns the rejection of vector from direction, i.e. projection of vector onto the plane defined by origin and direction

### 返回

[Vector3D](VRageMath.Vector3D)

Rejection of the vector from the given direction

### 参数

* [Vector3D](VRageMath.Vector3D) vector
* [Vector3D](VRageMath.Vector3D) direction
### 概要

```csharp
public static void Reject(ref Vector3D vector, ref Vector3D direction, out Vector3D result)
```

Returns the rejection of vector from direction, i.e. projection of vector onto the plane defined by origin and direction

### 参数

* [Vector3D](VRageMath.Vector3D) vector
* [Vector3D](VRageMath.Vector3D) direction
* [Vector3D](VRageMath.Vector3D) result
