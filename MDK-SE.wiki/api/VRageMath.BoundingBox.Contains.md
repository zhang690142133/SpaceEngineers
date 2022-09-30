← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBox](VRageMath.BoundingBox)

### 概要

```csharp
public ContainmentType Contains(BoundingBox box)
```

Tests whether the BoundingBox contains another BoundingBox.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingBox](VRageMath.BoundingBox) box
### 概要

```csharp
public void Contains(ref BoundingBox box, out ContainmentType result)
```

Tests whether the BoundingBox contains a BoundingBox.

### 参数

* [BoundingBox](VRageMath.BoundingBox) box
* [ContainmentType](VRageMath.ContainmentType) result
### 概要

```csharp
public ContainmentType Contains(BoundingFrustum frustum)
```

Tests whether the BoundingBox contains a BoundingFrustum.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
### 概要

```csharp
public ContainmentType Contains(Vector3 point)
```

Tests whether the BoundingBox contains a point.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [Vector3](VRageMath.Vector3) point
### 概要

```csharp
public ContainmentType Contains(Vector3D point)
```



### 返回

[ContainmentType](VRageMath.ContainmentType)



### 参数

* [Vector3D](VRageMath.Vector3D) point
### 概要

```csharp
public void Contains(ref Vector3 point, out ContainmentType result)
```

Tests whether the BoundingBox contains a point.

### 参数

* [Vector3](VRageMath.Vector3) point
* [ContainmentType](VRageMath.ContainmentType) result
### 概要

```csharp
public ContainmentType Contains(BoundingSphere sphere)
```

Tests whether the BoundingBox contains a BoundingSphere.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingSphere](VRageMath.BoundingSphere) sphere
### 概要

```csharp
public void Contains(ref BoundingSphere sphere, out ContainmentType result)
```

Tests whether the BoundingBox contains a BoundingSphere.

### 参数

* [BoundingSphere](VRageMath.BoundingSphere) sphere
* [ContainmentType](VRageMath.ContainmentType) result
