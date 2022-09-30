← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyOrientedBoundingBox Struct

```csharp
public struct MyOrientedBoundingBox: IEquatable<MyOrientedBoundingBox>
```

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;MyOrientedBoundingBox&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static int CornerCount](VRageMath.MyOrientedBoundingBox.CornerCount)

> 

[static Int32&#91&#93; EndVertices](VRageMath.MyOrientedBoundingBox.EndVertices)

> 

[static Int32&#91&#93; EndXVertices](VRageMath.MyOrientedBoundingBox.EndXVertices)

> 

[static Int32&#91&#93; EndYVertices](VRageMath.MyOrientedBoundingBox.EndYVertices)

> 

[static Int32&#91&#93; EndZVertices](VRageMath.MyOrientedBoundingBox.EndZVertices)

> 

[static Int32&#91&#93; StartVertices](VRageMath.MyOrientedBoundingBox.StartVertices)

> 

[static Int32&#91&#93; StartXVertices](VRageMath.MyOrientedBoundingBox.StartXVertices)

> 

[static Int32&#91&#93; StartYVertices](VRageMath.MyOrientedBoundingBox.StartYVertices)

> 

[static Int32&#91&#93; StartZVertices](VRageMath.MyOrientedBoundingBox.StartZVertices)

> 

[static Vector3&#91&#93; XNeighbourVectorsBack](VRageMath.MyOrientedBoundingBox.XNeighbourVectorsBack)

> 

[static Vector3&#91&#93; XNeighbourVectorsForw](VRageMath.MyOrientedBoundingBox.XNeighbourVectorsForw)

> 

[static Vector3&#91&#93; YNeighbourVectorsBack](VRageMath.MyOrientedBoundingBox.YNeighbourVectorsBack)

> 

[static Vector3&#91&#93; YNeighbourVectorsForw](VRageMath.MyOrientedBoundingBox.YNeighbourVectorsForw)

> 

[static Vector3&#91&#93; ZNeighbourVectorsBack](VRageMath.MyOrientedBoundingBox.ZNeighbourVectorsBack)

> 

[static Vector3&#91&#93; ZNeighbourVectorsForw](VRageMath.MyOrientedBoundingBox.ZNeighbourVectorsForw)

> 

[Vector3 Center](VRageMath.MyOrientedBoundingBox.Center)

> 

[Vector3 HalfExtent](VRageMath.MyOrientedBoundingBox.HalfExtent)

> 

[Quaternion Orientation](VRageMath.MyOrientedBoundingBox.Orientation)

> 

#### Constructors

[MyOrientedBoundingBox(ref Matrix matrix)](VRageMath.MyOrientedBoundingBox..ctor)

> 

[MyOrientedBoundingBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)](VRageMath.MyOrientedBoundingBox..ctor)

> 

#### 方法

[static ContainmentType Contains(ref BoundingBox boxA, ref MyOrientedBoundingBox oboxB)](VRageMath.MyOrientedBoundingBox.Contains)

> 

[static ContainmentType Contains(BoundingFrustum frustum, ref MyOrientedBoundingBox obox)](VRageMath.MyOrientedBoundingBox.Contains)

> 

[static ContainmentType Contains(ref BoundingSphere sphere, ref MyOrientedBoundingBox box)](VRageMath.MyOrientedBoundingBox.Contains)

> 

[static ContainmentType ContainsRelativeBox(ref Vector3 hA, ref Vector3 hB, ref Matrix mB)](VRageMath.MyOrientedBoundingBox.ContainsRelativeBox)

> 

[static MyOrientedBoundingBox Create(BoundingBox boundingBox, Matrix matrix)](VRageMath.MyOrientedBoundingBox.Create)

> 

[static MyOrientedBoundingBox CreateFromBoundingBox(BoundingBox box)](VRageMath.MyOrientedBoundingBox.CreateFromBoundingBox)

> 

[static bool GetNormalBetweenEdges(int axis, int edge0, int edge1, out Vector3 normal)](VRageMath.MyOrientedBoundingBox.GetNormalBetweenEdges)

> Returns normal between two cube edge of same direction

[ContainmentType Contains(ref BoundingBox box)](VRageMath.MyOrientedBoundingBox.Contains)

> 

[ContainmentType Contains(ref MyOrientedBoundingBox other)](VRageMath.MyOrientedBoundingBox.Contains)

> 

[ContainmentType Contains(BoundingFrustum frustum)](VRageMath.MyOrientedBoundingBox.Contains)

> 

[ContainmentType Contains(ref BoundingSphere sphere)](VRageMath.MyOrientedBoundingBox.Contains)

> 

[bool Contains(ref Vector3 point)](VRageMath.MyOrientedBoundingBox.Contains)

> 

[BoundingFrustum ConvertToFrustum()](VRageMath.MyOrientedBoundingBox.ConvertToFrustum)

> 

[bool Equals(MyOrientedBoundingBox other)](VRageMath.MyOrientedBoundingBox.Equals)

> 

[bool Equals(object obj)](VRageMath.MyOrientedBoundingBox.Equals)

> 

[BoundingBox GetAABB()](VRageMath.MyOrientedBoundingBox.GetAABB)

> 

[void GetCorners(Vector3&#91&#93; corners, int startIndex)](VRageMath.MyOrientedBoundingBox.GetCorners)

> 

[int GetHashCode()](VRageMath.MyOrientedBoundingBox.GetHashCode)

> 

[bool Intersects(ref BoundingBox box)](VRageMath.MyOrientedBoundingBox.Intersects)

> 

[bool Intersects(ref MyOrientedBoundingBox other)](VRageMath.MyOrientedBoundingBox.Intersects)

> 

[bool Intersects(BoundingFrustum frustum)](VRageMath.MyOrientedBoundingBox.Intersects)

> 

[bool Intersects(ref BoundingSphere sphere)](VRageMath.MyOrientedBoundingBox.Intersects)

> 

[float? Intersects(ref Ray ray)](VRageMath.MyOrientedBoundingBox.Intersects)

> 

[float? Intersects(ref Line line)](VRageMath.MyOrientedBoundingBox.Intersects)

> 

[PlaneIntersectionType Intersects(ref Plane plane)](VRageMath.MyOrientedBoundingBox.Intersects)

> 

[string ToString()](VRageMath.MyOrientedBoundingBox.ToString)

> 

[MyOrientedBoundingBox Transform(Quaternion rotation, Vector3 translation)](VRageMath.MyOrientedBoundingBox.Transform)

> 

[MyOrientedBoundingBox Transform(float scale, Quaternion rotation, Vector3 translation)](VRageMath.MyOrientedBoundingBox.Transform)

> 

[void Transform(Matrix matrix)](VRageMath.MyOrientedBoundingBox.Transform)

> 

