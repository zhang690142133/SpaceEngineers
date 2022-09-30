← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [PlaneD](VRageMath.PlaneD)

### 概要

```csharp
public PlaneIntersectionType Intersects(BoundingBoxD box)
```

Checks whether the current PlaneD intersects a specified BoundingBox.

### 返回

[PlaneIntersectionType](VRageMath.PlaneIntersectionType)

### 参数

* [BoundingBoxD](VRageMath.BoundingBoxD) box
### 概要

```csharp
public void Intersects(ref BoundingBoxD box, out PlaneIntersectionType result)
```

Checks whether the current PlaneD intersects a BoundingBox.

### 参数

* [BoundingBoxD](VRageMath.BoundingBoxD) box
* [PlaneIntersectionType](VRageMath.PlaneIntersectionType) result
### 概要

```csharp
public PlaneIntersectionType Intersects(BoundingFrustumD frustum)
```

Checks whether the current PlaneD intersects a specified BoundingFrustum.

### 返回

[PlaneIntersectionType](VRageMath.PlaneIntersectionType)

### 参数

* [BoundingFrustumD](VRageMath.BoundingFrustumD) frustum
### 概要

```csharp
public PlaneIntersectionType Intersects(BoundingSphereD sphere)
```

Checks whether the current PlaneD intersects a specified BoundingSphere.

### 返回

[PlaneIntersectionType](VRageMath.PlaneIntersectionType)

### 参数

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
### 概要

```csharp
public void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result)
```

Checks whether the current PlaneD intersects a BoundingSphere.

### 参数

* [BoundingSphere](VRageMath.BoundingSphere) sphere
* [PlaneIntersectionType](VRageMath.PlaneIntersectionType) result
