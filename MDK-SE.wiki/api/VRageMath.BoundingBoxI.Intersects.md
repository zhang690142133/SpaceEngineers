← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBoxI](VRageMath.BoundingBoxI)

### 概要

```csharp
public bool Intersects(BoundingBoxI box)
```

Checks whether the current BoundingBoxI intersects another BoundingBoxI.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

### 参数

* [BoundingBoxI](VRageMath.BoundingBoxI) box
### 概要

```csharp
public bool Intersects(ref BoundingBoxI box)
```



### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [BoundingBoxI](VRageMath.BoundingBoxI) box
### 概要

```csharp
public void Intersects(ref BoundingBoxI box, out bool result)
```

Checks whether the current BoundingBoxI intersects another BoundingBoxI.

### 参数

* [BoundingBoxI](VRageMath.BoundingBoxI) box
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) result
### 概要

```csharp
public PlaneIntersectionType Intersects(Plane plane)
```

Checks whether the current BoundingBoxI intersects a Plane.

### 返回

[PlaneIntersectionType](VRageMath.PlaneIntersectionType)

### 参数

* [Plane](VRageMath.Plane) plane
### 概要

```csharp
public void Intersects(ref Plane plane, out PlaneIntersectionType result)
```

Checks whether the current BoundingBoxI intersects a Plane.

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

Checks whether the current BoundingBoxI intersects a Ray.

### 返回

[float?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

### 参数

* [Ray](VRageMath.Ray) ray
### 概要

```csharp
public void Intersects(ref Ray ray, out float? result)
```

Checks whether the current BoundingBoxI intersects a Ray.

### 参数

* [Ray](VRageMath.Ray) ray
* [float?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) result
