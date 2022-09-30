← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [Vector3L](VRageMath.Vector3L)

### 概要

```csharp
public static IEnumerable<Vector3L> EnumerateRange(Vector3L minInclusive, Vector3L maxExclusive)
```

Enumerate all values in a longeger longerval (a cuboid). This method is an allocating version of the Vector3L_RangeIterator. This once can be used in the foreach syntax though so it's more convenient for debug routines.

### 返回

[IEnumerable&lt;Vector3L&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)

An iterator for that range.

### 参数

* [Vector3L](VRageMath.Vector3L) minInclusive
* [Vector3L](VRageMath.Vector3L) maxExclusive
