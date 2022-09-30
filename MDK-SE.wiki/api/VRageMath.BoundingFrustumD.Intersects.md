← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingFrustumD](VRageMath.BoundingFrustumD)

### 概要

```csharp
public bool Intersects(BoundingBoxD box)
```

Checks whether the current BoundingFrustumD intersects the specified BoundingBoxD.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

### 参数

* [BoundingBoxD](VRageMath.BoundingBoxD) box
### 概要

```csharp
public void Intersects(ref BoundingBoxD box, out bool result)
```

Checks whether the current BoundingFrustumD intersects a BoundingBoxD.

### 参数

* [BoundingBoxD](VRageMath.BoundingBoxD) box
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) result
### 概要

```csharp
public bool Intersects(BoundingFrustumD frustum)
```

Checks whether the current BoundingFrustumD intersects the specified BoundingFrustumD.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

### 参数

* [BoundingFrustumD](VRageMath.BoundingFrustumD) frustum
### 概要

```csharp
public PlaneIntersectionType Intersects(PlaneD plane)
```

Checks whether the current BoundingFrustumD intersects the specified Plane.

### 返回

[PlaneIntersectionType](VRageMath.PlaneIntersectionType)

### 参数

* [PlaneD](VRageMath.PlaneD) plane
### 概要

```csharp
public void Intersects(ref PlaneD plane, out PlaneIntersectionType result)
```

Checks whether the current BoundingFrustumD intersects a Plane.

### 参数

* [PlaneD](VRageMath.PlaneD) plane
* [PlaneIntersectionType](VRageMath.PlaneIntersectionType) result
### 概要

```csharp
public double? Intersects(RayD ray)
```

Checks whether the current BoundingFrustumD intersects the specified Ray.

### 返回

[double?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

### 参数

* [RayD](VRageMath.RayD) ray
### 概要

```csharp
public void Intersects(ref RayD ray, out double? result)
```

Checks whether the current BoundingFrustumD intersects a Ray.

### 参数

* [RayD](VRageMath.RayD) ray
* [double?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) result
### 概要

```csharp
public bool Intersects(BoundingSphereD sphere)
```

Checks whether the current BoundingFrustumD intersects the specified BoundingSphere.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

### 参数

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
### 概要

```csharp
public void Intersects(ref BoundingSphereD sphere, out bool result)
```

Checks whether the current BoundingFrustumD intersects a BoundingSphere.

### 参数

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) result
