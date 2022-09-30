← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBoxD](VRageMath.BoundingBoxD)

### 概要

```csharp
public ContainmentType Contains(BoundingBoxD box)
```

Tests whether the BoundingBox contains another BoundingBox.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingBoxD](VRageMath.BoundingBoxD) box
### 概要

```csharp
public void Contains(ref BoundingBoxD box, out ContainmentType result)
```

Tests whether the BoundingBox contains a BoundingBox.

### 参数

* [BoundingBoxD](VRageMath.BoundingBoxD) box
* [ContainmentType](VRageMath.ContainmentType) result
### 概要

```csharp
public ContainmentType Contains(BoundingFrustumD frustum)
```

Tests whether the BoundingBox contains a BoundingFrustum.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingFrustumD](VRageMath.BoundingFrustumD) frustum
### 概要

```csharp
public ContainmentType Contains(Vector3D point)
```

Tests whether the BoundingBox contains a point.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [Vector3D](VRageMath.Vector3D) point
### 概要

```csharp
public void Contains(ref Vector3D point, out ContainmentType result)
```

Tests whether the BoundingBox contains a point.

### 参数

* [Vector3D](VRageMath.Vector3D) point
* [ContainmentType](VRageMath.ContainmentType) result
### 概要

```csharp
public ContainmentType Contains(BoundingSphereD sphere)
```

Tests whether the BoundingBox contains a BoundingSphere.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
### 概要

```csharp
public void Contains(ref BoundingSphereD sphere, out ContainmentType result)
```

Tests whether the BoundingBox contains a BoundingSphere.

### 参数

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
* [ContainmentType](VRageMath.ContainmentType) result
