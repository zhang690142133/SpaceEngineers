← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [BoundingBoxI](VRageMath.BoundingBoxI)

### 概要

```csharp
public static IEnumerable<Vector3I> EnumeratePoints(BoundingBoxI rangeInclusive)
```

Enumerate all values in a integer interval (a cuboid). This method is an allocating version of the Vector3I_RangeIterator. This once can be used in the foreach syntax though so it's more convenient for debug routines.

### 返回

[IEnumerable&lt;Vector3I&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)

An iterator for that range.

### 参数

* [BoundingBoxI](VRageMath.BoundingBoxI) rangeInclusive
