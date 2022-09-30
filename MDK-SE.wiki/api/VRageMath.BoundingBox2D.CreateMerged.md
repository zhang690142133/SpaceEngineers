← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBox2D](VRageMath.BoundingBox2D)

### 概要

```csharp
public static BoundingBox2D CreateMerged(BoundingBox2D original, BoundingBox2D additional)
```

Creates the smallest BoundingBox2D that contains the two specified BoundingBox2D instances.

### 返回

[BoundingBox2D](VRageMath.BoundingBox2D)

### 参数

* [BoundingBox2D](VRageMath.BoundingBox2D) original
* [BoundingBox2D](VRageMath.BoundingBox2D) additional
### 概要

```csharp
public static void CreateMerged(ref BoundingBox2D original, ref BoundingBox2D additional, out BoundingBox2D result)
```

Creates the smallest BoundingBox2D that contains the two specified BoundingBox2D instances.

### 参数

* [BoundingBox2D](VRageMath.BoundingBox2D) original
* [BoundingBox2D](VRageMath.BoundingBox2D) additional
* [BoundingBox2D](VRageMath.BoundingBox2D) result
