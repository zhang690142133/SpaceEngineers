← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyDynamicAABBTreeD Class

```csharp
public class MyDynamicAABBTreeD
```

Dynamic aabb tree implementation as a prunning structure

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[static int NullNode](VRageMath.MyDynamicAABBTreeD.NullNode)

> A dynamic tree arranges data in a binary tree to accelerate queries such as volume queries and ray casts. Leafs are proxies with an BoundingBox. In the tree we expand the proxy BoundingBox by Settings.b2_fatAABBFactor so that the proxy BoundingBox is bigger than the client object. This allows the client object to move by small amounts without triggering a tree update. Nodes are pooled and relocatable, so we use node indices rather than pointers.

#### Properties

[int ElementsCount { get; }](VRageMath.MyDynamicAABBTreeD.ElementsCount)

> 

#### Constructors

[MyDynamicAABBTreeD()](VRageMath.MyDynamicAABBTreeD..ctor)

> 

[MyDynamicAABBTreeD(Vector3D extension, double aabbMultiplier = 1)](VRageMath.MyDynamicAABBTreeD..ctor)

> 

#### 方法

[static void Dispose()](VRageMath.MyDynamicAABBTreeD.Dispose)

> 

[int AddProxy(ref BoundingBoxD aabb, object userData, uint userFlags, bool rebalance = default)](VRageMath.MyDynamicAABBTreeD.AddProxy)

> Create a proxy. Provide a tight fitting BoundingBox and a userData pointer.

[int Balance(int iA)](VRageMath.MyDynamicAABBTreeD.Balance)

> 

[void Clear()](VRageMath.MyDynamicAABBTreeD.Clear)

> 

[int CountLeaves(int nodeId)](VRageMath.MyDynamicAABBTreeD.CountLeaves)

> 

[BoundingBoxD GetAabb(int proxyId)](VRageMath.MyDynamicAABBTreeD.GetAabb)

> 

[void GetAll&lt;T&gt;(List&lt;T&gt; elementsList, bool clear, List&lt;BoundingBoxD&gt; boxsList = null)](VRageMath.MyDynamicAABBTreeD.GetAll)

> 

[void GetAll&lt;T&gt;(Action&lt;T&gt; add)](VRageMath.MyDynamicAABBTreeD.GetAll)

> 

[void GetAll&lt;T&gt;(Action&lt;T, BoundingBoxD&gt; add)](VRageMath.MyDynamicAABBTreeD.GetAll)

> 

[void GetAllNodeBounds(List&lt;BoundingBoxD&gt; boxsList)](VRageMath.MyDynamicAABBTreeD.GetAllNodeBounds)

> 

[void GetAproximateClustersForAabb(ref BoundingBoxD bbox, double minSize, List&lt;BoundingBoxD&gt; boundList)](VRageMath.MyDynamicAABBTreeD.GetAproximateClustersForAabb)

> 

[void GetChildren(int proxyId, out int left, out int right)](VRageMath.MyDynamicAABBTreeD.GetChildren)

> 

[void GetFatAABB(int proxyId, out BoundingBoxD fatAABB)](VRageMath.MyDynamicAABBTreeD.GetFatAABB)

> Get the fat BoundingBox for a proxy.

[int GetHeight()](VRageMath.MyDynamicAABBTreeD.GetHeight)

> 

[int GetLeafCount(int proxyId)](VRageMath.MyDynamicAABBTreeD.GetLeafCount)

> 

[void GetNodeLeaves(int proxyId, List&lt;int&gt; children)](VRageMath.MyDynamicAABBTreeD.GetNodeLeaves)

> 

[int GetRoot()](VRageMath.MyDynamicAABBTreeD.GetRoot)

> 

[T GetUserData&lt;T&gt;(int proxyId)](VRageMath.MyDynamicAABBTreeD.GetUserData)

> 

[bool IsRootNull()](VRageMath.MyDynamicAABBTreeD.IsRootNull)

> 

[bool MoveProxy(int proxyId, ref BoundingBoxD aabb, Vector3D displacement)](VRageMath.MyDynamicAABBTreeD.MoveProxy)

> Move a proxy with a swepted BoundingBox. If the proxy has moved outside of its fattened BoundingBox, then the proxy is removed from the tree and re-inserted. Otherwise the function returns immediately.

[void OverlapAllBoundingBox&lt;T&gt;(ref BoundingBoxD bbox, List&lt;T&gt; elementsList, uint requiredFlags = 0, bool clear = default)](VRageMath.MyDynamicAABBTreeD.OverlapAllBoundingBox)

> 

[void OverlapAllBoundingBox&lt;T&gt;(ref MyOrientedBoundingBoxD obb, List&lt;T&gt; elementsList, uint requiredFlags = 0, bool clear = default)](VRageMath.MyDynamicAABBTreeD.OverlapAllBoundingBox)

> 

[void OverlapAllBoundingSphere&lt;T&gt;(ref BoundingSphereD sphere, List&lt;T&gt; overlapElementsList, bool clear = default)](VRageMath.MyDynamicAABBTreeD.OverlapAllBoundingSphere)

> 

[void OverlapAllBoundingSphere&lt;T&gt;(ref BoundingSphereD sphere, Action&lt;T&gt; addAction)](VRageMath.MyDynamicAABBTreeD.OverlapAllBoundingSphere)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustumD frustum, List&lt;T&gt; elementsList, bool clear = default)](VRageMath.MyDynamicAABBTreeD.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustumD frustum, List&lt;T&gt; elementsList, uint requiredFlags, bool clear = default)](VRageMath.MyDynamicAABBTreeD.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustumD frustum, List&lt;T&gt; elementsList, List&lt;bool&gt; isInsideList)](VRageMath.MyDynamicAABBTreeD.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustumD frustum, T results)](VRageMath.MyDynamicAABBTreeD.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustumD frustum, List&lt;T&gt; elementsList, List&lt;bool&gt; isInsideList, float tSqr, bool clear = default)](VRageMath.MyDynamicAABBTreeD.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustumD frustum, Action&lt;T, bool&gt; add, float tSqr)](VRageMath.MyDynamicAABBTreeD.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustumD frustum, T results, float tSqr)](VRageMath.MyDynamicAABBTreeD.OverlapAllFrustum)

> 

[void OverlapAllFrustumAny&lt;T&gt;(ref BoundingFrustumD frustum, List&lt;T&gt; elementsList, bool clear = default)](VRageMath.MyDynamicAABBTreeD.OverlapAllFrustumAny)

> 

[void OverlapAllLineSegment&lt;T&gt;(ref LineD line, List&lt;MyLineSegmentOverlapResult&lt;T&gt;&gt; elementsList, bool clear = default)](VRageMath.MyDynamicAABBTreeD.OverlapAllLineSegment)

> 

[void OverlapAllLineSegment&lt;T&gt;(ref LineD line, List&lt;MyLineSegmentOverlapResult&lt;T&gt;&gt; elementsList, uint requiredFlags, bool clear = default)](VRageMath.MyDynamicAABBTreeD.OverlapAllLineSegment)

> 

[bool OverlapsAnyLeafBoundingBox(ref BoundingBoxD bbox)](VRageMath.MyDynamicAABBTreeD.OverlapsAnyLeafBoundingBox)

> 

[void Query(Func&lt;int, bool&gt; callback, ref BoundingBoxD aabb)](VRageMath.MyDynamicAABBTreeD.Query)

> 

[void QueryPoint(Func&lt;int, bool&gt; callback, ref Vector3D point)](VRageMath.MyDynamicAABBTreeD.QueryPoint)

> 

[void RemoveProxy(int proxyId)](VRageMath.MyDynamicAABBTreeD.RemoveProxy)

> Destroy a proxy. This asserts if the id is invalid.

