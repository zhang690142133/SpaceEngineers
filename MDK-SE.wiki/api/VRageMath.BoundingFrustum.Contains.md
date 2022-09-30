← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingFrustum](VRageMath.BoundingFrustum)

### 概要

```csharp
public ContainmentType Contains(ref BoundingBox box)
```

Checks whether the current BoundingFrustum contains the specified BoundingBox.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingBox](VRageMath.BoundingBox) box
### 概要

```csharp
public void Contains(ref BoundingBox box, out ContainmentType result)
```

Checks whether the current BoundingFrustum contains the specified BoundingBox.

### 参数

* [BoundingBox](VRageMath.BoundingBox) box
* [ContainmentType](VRageMath.ContainmentType) result
### 概要

```csharp
public ContainmentType Contains(BoundingFrustum frustum)
```

Checks whether the current BoundingFrustum contains the specified BoundingFrustum.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
### 概要

```csharp
public ContainmentType Contains(Vector3 point)
```

Checks whether the current BoundingFrustum contains the specified point.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [Vector3](VRageMath.Vector3) point
### 概要

```csharp
public void Contains(ref Vector3 point, out ContainmentType result)
```

Checks whether the current BoundingFrustum contains the specified point.

### 参数

* [Vector3](VRageMath.Vector3) point
* [ContainmentType](VRageMath.ContainmentType) result
### 概要

```csharp
public ContainmentType Contains(BoundingSphere sphere)
```

Checks whether the current BoundingFrustum contains the specified BoundingSphere.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingSphere](VRageMath.BoundingSphere) sphere
### 概要

```csharp
public void Contains(ref BoundingSphere sphere, out ContainmentType result)
```

Checks whether the current BoundingFrustum contains the specified BoundingSphere.

### 参数

* [BoundingSphere](VRageMath.BoundingSphere) sphere
* [ContainmentType](VRageMath.ContainmentType) result
