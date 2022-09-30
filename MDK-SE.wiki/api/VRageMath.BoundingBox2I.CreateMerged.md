← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBox2I](VRageMath.BoundingBox2I)

### 概要

```csharp
public static BoundingBox2I CreateMerged(BoundingBox2I original, BoundingBox2I additional)
```

Creates the smallest BoundingBox2I that contains the two specified BoundingBox2I instances.

### 返回

[BoundingBox2I](VRageMath.BoundingBox2I)

### 参数

* [BoundingBox2I](VRageMath.BoundingBox2I) original
* [BoundingBox2I](VRageMath.BoundingBox2I) additional
### 概要

```csharp
public static void CreateMerged(ref BoundingBox2I original, ref BoundingBox2I additional, out BoundingBox2I result)
```

Creates the smallest BoundingBox2I that contains the two specified BoundingBox2I instances.

### 参数

* [BoundingBox2I](VRageMath.BoundingBox2I) original
* [BoundingBox2I](VRageMath.BoundingBox2I) additional
* [BoundingBox2I](VRageMath.BoundingBox2I) result
