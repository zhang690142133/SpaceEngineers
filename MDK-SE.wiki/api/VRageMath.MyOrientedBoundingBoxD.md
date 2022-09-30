← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyOrientedBoundingBoxD Struct

```csharp
public struct MyOrientedBoundingBoxD: IEquatable<MyOrientedBoundingBox>
```

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;MyOrientedBoundingBox&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static int CornerCount](VRageMath.MyOrientedBoundingBoxD.CornerCount)

> 

[static Int32&#91&#93; EndVertices](VRageMath.MyOrientedBoundingBoxD.EndVertices)

> 

[static Int32&#91&#93; EndXVertices](VRageMath.MyOrientedBoundingBoxD.EndXVertices)

> 

[static Int32&#91&#93; EndYVertices](VRageMath.MyOrientedBoundingBoxD.EndYVertices)

> 

[static Int32&#91&#93; EndZVertices](VRageMath.MyOrientedBoundingBoxD.EndZVertices)

> 

[static Int32&#91&#93; StartVertices](VRageMath.MyOrientedBoundingBoxD.StartVertices)

> 

[static Int32&#91&#93; StartXVertices](VRageMath.MyOrientedBoundingBoxD.StartXVertices)

> 

[static Int32&#91&#93; StartYVertices](VRageMath.MyOrientedBoundingBoxD.StartYVertices)

> 

[static Int32&#91&#93; StartZVertices](VRageMath.MyOrientedBoundingBoxD.StartZVertices)

> 

[static Vector3&#91&#93; XNeighbourVectorsBack](VRageMath.MyOrientedBoundingBoxD.XNeighbourVectorsBack)

> 

[static Vector3&#91&#93; XNeighbourVectorsForw](VRageMath.MyOrientedBoundingBoxD.XNeighbourVectorsForw)

> 

[static Vector3&#91&#93; YNeighbourVectorsBack](VRageMath.MyOrientedBoundingBoxD.YNeighbourVectorsBack)

> 

[static Vector3&#91&#93; YNeighbourVectorsForw](VRageMath.MyOrientedBoundingBoxD.YNeighbourVectorsForw)

> 

[static Vector3&#91&#93; ZNeighbourVectorsBack](VRageMath.MyOrientedBoundingBoxD.ZNeighbourVectorsBack)

> 

[static Vector3&#91&#93; ZNeighbourVectorsForw](VRageMath.MyOrientedBoundingBoxD.ZNeighbourVectorsForw)

> 

[Vector3D Center](VRageMath.MyOrientedBoundingBoxD.Center)

> 

[Vector3D HalfExtent](VRageMath.MyOrientedBoundingBoxD.HalfExtent)

> 

[Quaternion Orientation](VRageMath.MyOrientedBoundingBoxD.Orientation)

> 

#### Constructors

[MyOrientedBoundingBoxD(MatrixD matrix)](VRageMath.MyOrientedBoundingBoxD..ctor)

> 

[MyOrientedBoundingBoxD(Vector3D center, Vector3D halfExtents, Quaternion orientation)](VRageMath.MyOrientedBoundingBoxD..ctor)

> 

[MyOrientedBoundingBoxD(BoundingBoxD box, MatrixD transform)](VRageMath.MyOrientedBoundingBoxD..ctor)

> 

#### 方法

[static ContainmentType Contains(ref BoundingBox boxA, ref MyOrientedBoundingBox oboxB)](VRageMath.MyOrientedBoundingBoxD.Contains)

> 

[static ContainmentType Contains(BoundingFrustumD frustum, ref MyOrientedBoundingBoxD obox)](VRageMath.MyOrientedBoundingBoxD.Contains)

> 

[static ContainmentType Contains(ref BoundingSphere sphere, ref MyOrientedBoundingBox box)](VRageMath.MyOrientedBoundingBoxD.Contains)

> 

[static ContainmentType ContainsRelativeBox(ref Vector3D hA, ref Vector3D hB, ref MatrixD mB)](VRageMath.MyOrientedBoundingBoxD.ContainsRelativeBox)

> 

[static MyOrientedBoundingBoxD Create(BoundingBoxD boundingBox, MatrixD matrix)](VRageMath.MyOrientedBoundingBoxD.Create)

> 

[static MyOrientedBoundingBoxD CreateFromBoundingBox(BoundingBoxD box)](VRageMath.MyOrientedBoundingBoxD.CreateFromBoundingBox)

> 

[static bool GetNormalBetweenEdges(int axis, int edge0, int edge1, out Vector3 normal)](VRageMath.MyOrientedBoundingBoxD.GetNormalBetweenEdges)

> Returns normal between two cube edge of same direction

[ContainmentType Contains(ref BoundingBox box)](VRageMath.MyOrientedBoundingBoxD.Contains)

> 

[ContainmentType Contains(ref BoundingBoxD box)](VRageMath.MyOrientedBoundingBoxD.Contains)

> 

[ContainmentType Contains(ref MyOrientedBoundingBoxD other)](VRageMath.MyOrientedBoundingBoxD.Contains)

> 

[ContainmentType Contains(BoundingFrustumD frustum)](VRageMath.MyOrientedBoundingBoxD.Contains)

> 

[ContainmentType Contains(ref BoundingSphereD sphere)](VRageMath.MyOrientedBoundingBoxD.Contains)

> 

[bool Contains(ref Vector3 point)](VRageMath.MyOrientedBoundingBoxD.Contains)

> 

[bool Contains(ref Vector3D point)](VRageMath.MyOrientedBoundingBoxD.Contains)

> 

[BoundingFrustumD ConvertToFrustum()](VRageMath.MyOrientedBoundingBoxD.ConvertToFrustum)

> 

[float Distance(RayD ray)](VRageMath.MyOrientedBoundingBoxD.Distance)

> 

[bool Equals(MyOrientedBoundingBox other)](VRageMath.MyOrientedBoundingBoxD.Equals)

> 

[bool Equals(object obj)](VRageMath.MyOrientedBoundingBoxD.Equals)

> 

[BoundingBoxD GetAABB()](VRageMath.MyOrientedBoundingBoxD.GetAABB)

> 

[void GetCorners(Vector3D&#91&#93; corners, int startIndex)](VRageMath.MyOrientedBoundingBoxD.GetCorners)

> 

[int GetHashCode()](VRageMath.MyOrientedBoundingBoxD.GetHashCode)

> 

[bool Intersects(ref BoundingBox box)](VRageMath.MyOrientedBoundingBoxD.Intersects)

> 

[bool Intersects(ref BoundingBoxD box)](VRageMath.MyOrientedBoundingBoxD.Intersects)

> 

[bool Intersects(ref MyOrientedBoundingBoxD other)](VRageMath.MyOrientedBoundingBoxD.Intersects)

> 

[bool Intersects(BoundingFrustumD frustum)](VRageMath.MyOrientedBoundingBoxD.Intersects)

> 

[bool Intersects(ref BoundingSphereD sphere)](VRageMath.MyOrientedBoundingBoxD.Intersects)

> 

[double? Intersects(ref RayD ray)](VRageMath.MyOrientedBoundingBoxD.Intersects)

> 

[double? Intersects(ref LineD line)](VRageMath.MyOrientedBoundingBoxD.Intersects)

> 

[PlaneIntersectionType Intersects(ref PlaneD plane)](VRageMath.MyOrientedBoundingBoxD.Intersects)

> 

[double? IntersectsOrContains(ref LineD line)](VRageMath.MyOrientedBoundingBoxD.IntersectsOrContains)

> 

[string ToString()](VRageMath.MyOrientedBoundingBoxD.ToString)

> 

[MyOrientedBoundingBoxD Transform(Quaternion rotation, Vector3D translation)](VRageMath.MyOrientedBoundingBoxD.Transform)

> 

[MyOrientedBoundingBoxD Transform(float scale, Quaternion rotation, Vector3D translation)](VRageMath.MyOrientedBoundingBoxD.Transform)

> 

[void Transform(MatrixD matrix)](VRageMath.MyOrientedBoundingBoxD.Transform)

> 

[void Transform(ref MatrixD matrix)](VRageMath.MyOrientedBoundingBoxD.Transform)

> 

