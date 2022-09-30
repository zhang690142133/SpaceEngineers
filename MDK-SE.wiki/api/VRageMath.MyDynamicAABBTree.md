← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyDynamicAABBTree Class

```csharp
public class MyDynamicAABBTree
```

Dynamic aabb tree implementation as a prunning structure

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[static int NullNode](VRageMath.MyDynamicAABBTree.NullNode)

> A dynamic tree arranges data in a binary tree to accelerate queries such as volume queries and ray casts. Leafs are proxies with an BoundingBox. In the tree we expand the proxy BoundingBox by Settings.b2_fatAABBFactor so that the proxy BoundingBox is bigger than the client object. This allows the client object to move by small amounts without triggering a tree update. Nodes are pooled and relocatable, so we use node indices rather than pointers.

#### Properties

[DictionaryValuesReader&lt;int, DynamicTreeNode&gt; Leaves { get; }](VRageMath.MyDynamicAABBTree.Leaves)

> 

[ReadOnlySpan&lt;DynamicTreeNode&gt; Nodes { get; }](VRageMath.MyDynamicAABBTree.Nodes)

> 

#### Constructors

[MyDynamicAABBTree()](VRageMath.MyDynamicAABBTree..ctor)

> 

[MyDynamicAABBTree(Vector3 extension, float aabbMultiplier = 1)](VRageMath.MyDynamicAABBTree..ctor)

> 

#### 方法

[static void Dispose()](VRageMath.MyDynamicAABBTree.Dispose)

> 

[int AddProxy(ref BoundingBox aabb, object userData, uint userFlags, bool rebalance = default)](VRageMath.MyDynamicAABBTree.AddProxy)

> Create a proxy. Provide a tight fitting BoundingBox and a userData pointer.

[int Balance(int iA)](VRageMath.MyDynamicAABBTree.Balance)

> 

[void Clear()](VRageMath.MyDynamicAABBTree.Clear)

> 

[int CountLeaves(int nodeId)](VRageMath.MyDynamicAABBTree.CountLeaves)

> 

[BoundingBox GetAabb(int proxyId)](VRageMath.MyDynamicAABBTree.GetAabb)

> 

[void GetAll&lt;T&gt;(List&lt;T&gt; elementsList, bool clear, List&lt;BoundingBox&gt; boxsList = null)](VRageMath.MyDynamicAABBTree.GetAll)

> 

[void GetAllNodeBounds(List&lt;BoundingBox&gt; boxsList)](VRageMath.MyDynamicAABBTree.GetAllNodeBounds)

> 

[void GetChildren(int proxyId, out int left, out int right)](VRageMath.MyDynamicAABBTree.GetChildren)

> 

[void GetFatAABB(int proxyId, out BoundingBox fatAABB)](VRageMath.MyDynamicAABBTree.GetFatAABB)

> Get the fat BoundingBox for a proxy.

[int GetHeight()](VRageMath.MyDynamicAABBTree.GetHeight)

> 

[int GetLeafCount()](VRageMath.MyDynamicAABBTree.GetLeafCount)

> 

[int GetLeafCount(int proxyId)](VRageMath.MyDynamicAABBTree.GetLeafCount)

> 

[void GetNodeLeaves(int proxyId, List&lt;int&gt; children)](VRageMath.MyDynamicAABBTree.GetNodeLeaves)

> 

[int GetRoot()](VRageMath.MyDynamicAABBTree.GetRoot)

> 

[T GetUserData&lt;T&gt;(int proxyId)](VRageMath.MyDynamicAABBTree.GetUserData)

> 

[bool MoveProxy(int proxyId, ref BoundingBox aabb, Vector3 displacement)](VRageMath.MyDynamicAABBTree.MoveProxy)

> Move a proxy with a swepted BoundingBox. If the proxy has moved outside of its fattened BoundingBox, then the proxy is removed from the tree and re-inserted. Otherwise the function returns immediately.

[void OverlapAllBoundingBox&lt;T&gt;(ref BoundingBox bbox, List&lt;T&gt; elementsList, uint requiredFlags = 0, bool clear = default)](VRageMath.MyDynamicAABBTree.OverlapAllBoundingBox)

> 

[void OverlapAllBoundingSphere&lt;T&gt;(ref BoundingSphere sphere, List&lt;T&gt; overlapElementsList, bool clear = default)](VRageMath.MyDynamicAABBTree.OverlapAllBoundingSphere)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustum frustum, List&lt;T&gt; elementsList, bool clear = default)](VRageMath.MyDynamicAABBTree.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustum frustum, List&lt;T&gt; elementsList, uint requiredFlags, bool clear = default)](VRageMath.MyDynamicAABBTree.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustum frustum, List&lt;T&gt; elementsList, List&lt;bool&gt; isInsideList, bool clear = default)](VRageMath.MyDynamicAABBTree.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustum frustum, Action&lt;T, bool&gt; add)](VRageMath.MyDynamicAABBTree.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T, Op&gt;(ref BoundingFrustum frustum, ref Op add)](VRageMath.MyDynamicAABBTree.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustum frustum, List&lt;T&gt; elementsList, List&lt;bool&gt; isInsideList, float tSqr, bool clear = default)](VRageMath.MyDynamicAABBTree.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T&gt;(ref BoundingFrustum frustum, Action&lt;T, bool&gt; add, float tSqr)](VRageMath.MyDynamicAABBTree.OverlapAllFrustum)

> 

[void OverlapAllFrustum&lt;T, Op&gt;(ref BoundingFrustum frustum, float tSqr, ref Op add)](VRageMath.MyDynamicAABBTree.OverlapAllFrustum)

> 

[void OverlapAllFrustumAny&lt;T&gt;(ref BoundingFrustum frustum, List&lt;T&gt; elementsList, bool clear = default)](VRageMath.MyDynamicAABBTree.OverlapAllFrustumAny)

> 

[void OverlapAllFrustumConservative&lt;T&gt;(ref BoundingFrustum frustum, List&lt;T&gt; elementsList, uint requiredFlags, bool clear = default)](VRageMath.MyDynamicAABBTree.OverlapAllFrustumConservative)

> 

[void OverlapAllLineSegment&lt;T&gt;(ref Line line, List&lt;MyLineSegmentOverlapResult&lt;T&gt;&gt; elementsList)](VRageMath.MyDynamicAABBTree.OverlapAllLineSegment)

> 

[void OverlapAllLineSegment&lt;T&gt;(ref Line line, List&lt;MyLineSegmentOverlapResult&lt;T&gt;&gt; elementsList, uint requiredFlags)](VRageMath.MyDynamicAABBTree.OverlapAllLineSegment)

> 

[bool OverlapsAnyLeafBoundingBox(ref BoundingBox bbox)](VRageMath.MyDynamicAABBTree.OverlapsAnyLeafBoundingBox)

> 

[void OverlapSizeableClusters(ref BoundingBox bbox, List&lt;BoundingBox&gt; boundList, double minSize)](VRageMath.MyDynamicAABBTree.OverlapSizeableClusters)

> 

[void Query(Func&lt;int, bool&gt; callback, ref BoundingBox aabb)](VRageMath.MyDynamicAABBTree.Query)

> 

[void RemoveProxy(int proxyId)](VRageMath.MyDynamicAABBTree.RemoveProxy)

> Destroy a proxy. This asserts if the id is invalid.

