← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBox2D](VRageMath.BoundingBox2D)

### 概要

```csharp
public ContainmentType Contains(BoundingBox2D box)
```

Tests whether the BoundingBox2D contains another BoundingBox2D.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [BoundingBox2D](VRageMath.BoundingBox2D) box
### 概要

```csharp
public void Contains(ref BoundingBox2D box, out ContainmentType result)
```

Tests whether the BoundingBox2D contains a BoundingBox2D.

### 参数

* [BoundingBox2D](VRageMath.BoundingBox2D) box
* [ContainmentType](VRageMath.ContainmentType) result
### 概要

```csharp
public ContainmentType Contains(Vector2D point)
```

Tests whether the BoundingBox2D contains a point.

### 返回

[ContainmentType](VRageMath.ContainmentType)

### 参数

* [Vector2D](VRageMath.Vector2D) point
### 概要

```csharp
public void Contains(ref Vector2D point, out ContainmentType result)
```

Tests whether the BoundingBox2D contains a point.

### 参数

* [Vector2D](VRageMath.Vector2D) point
* [ContainmentType](VRageMath.ContainmentType) result
