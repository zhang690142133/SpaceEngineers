← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBox](VRageMath.BoundingBox)

### 概要

```csharp
public bool Intersects(BoundingBox box)
```

Checks whether the current BoundingBox intersects another BoundingBox.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

### 参数

* [BoundingBox](VRageMath.BoundingBox) box
### 概要

```csharp
public bool Intersects(ref BoundingBox box)
```



### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [BoundingBox](VRageMath.BoundingBox) box
### 概要

```csharp
public void Intersects(ref BoundingBox box, out bool result)
```

Checks whether the current BoundingBox intersects another BoundingBox.

### 参数

* [BoundingBox](VRageMath.BoundingBox) box
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) result
### 概要

```csharp
public bool Intersects(BoundingFrustum frustum)
```

Checks whether the current BoundingBox intersects a BoundingFrustum.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
### 概要

```csharp
public PlaneIntersectionType Intersects(Plane plane)
```

Checks whether the current BoundingBox intersects a Plane.

### 返回

[PlaneIntersectionType](VRageMath.PlaneIntersectionType)

### 参数

* [Plane](VRageMath.Plane) plane
### 概要

```csharp
public void Intersects(ref Plane plane, out PlaneIntersectionType result)
```

Checks whether the current BoundingBox intersects a Plane.

### 参数

* [Plane](VRageMath.Plane) plane
* [PlaneIntersectionType](VRageMath.PlaneIntersectionType) result
### 概要

```csharp
public bool Intersects(Line line, out float distance)
```



### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [Line](VRageMath.Line) line
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) distance
### 概要

```csharp
public float? Intersects(Ray ray)
```

Checks whether the current BoundingBox intersects a Ray.

### 返回

[float?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

### 参数

* [Ray](VRageMath.Ray) ray
### 概要

```csharp
public void Intersects(ref Ray ray, out float? result)
```

Checks whether the current BoundingBox intersects a Ray.

### 参数

* [Ray](VRageMath.Ray) ray
* [float?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) result
### 概要

```csharp
public bool Intersects(BoundingSphere sphere)
```

Checks whether the current BoundingBox intersects a BoundingSphere.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

### 参数

* [BoundingSphere](VRageMath.BoundingSphere) sphere
### 概要

```csharp
public void Intersects(ref BoundingSphere sphere, out bool result)
```

Checks whether the current BoundingBox intersects a BoundingSphere.

### 参数

* [BoundingSphere](VRageMath.BoundingSphere) sphere
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) result
### 概要

```csharp
public bool Intersects(ref BoundingSphere sphere)
```



### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [BoundingSphere](VRageMath.BoundingSphere) sphere
### 概要

```csharp
public bool Intersects(ref BoundingSphereD sphere)
```



### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
