← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingFrustumExtensions](VRageMath.BoundingFrustumExtensions)

### 概要

```csharp
public static BoundingSphere ToBoundingSphere(this BoundingFrustum frustum, Vector3[] corners)
```

Creates bounding sphere from bounding frustum. Implementation taken from XNA source, replace IEnumerable with array

### 返回

[BoundingSphere](VRageMath.BoundingSphere)

BoundingSphere

### 参数

* [BoundingFrustum](VRageMath.BoundingFrustum) frustum
* [Vector3&#91&#93;](VRageMath.Vector3&#91&#93;) corners
