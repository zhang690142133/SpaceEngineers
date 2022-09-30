← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### BoundingBox2D Struct

```csharp
public struct BoundingBox2D: IEquatable<BoundingBox2D>
```

Defines an axis-aligned box-shaped 2D volume.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;BoundingBox2D&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static int CornerCount](VRageMath.BoundingBox2D.CornerCount)

> Specifies the total number of corners (8) in the BoundingBox2D.

[Vector2D Max](VRageMath.BoundingBox2D.Max)

> The maximum point the BoundingBox2D contains.

[Vector2D Min](VRageMath.BoundingBox2D.Min)

> The minimum point the BoundingBox2D contains.

#### Properties

[Vector2D Center { get; }](VRageMath.BoundingBox2D.Center)

> Calculates center

[Vector2D Extents { get; }](VRageMath.BoundingBox2D.Extents)

> 

[Vector2D HalfExtents { get; }](VRageMath.BoundingBox2D.HalfExtents)

> 

[double Height { get; }](VRageMath.BoundingBox2D.Height)

> 

[Vector2D Size { get; }](VRageMath.BoundingBox2D.Size)

> Size

[double Width { get; }](VRageMath.BoundingBox2D.Width)

> 

#### Constructors

[BoundingBox2D(Vector2D min, Vector2D max)](VRageMath.BoundingBox2D..ctor)

> 

#### 方法

[static BoundingBox2D CreateFromHalfExtent(Vector2D center, double halfExtent)](VRageMath.BoundingBox2D.CreateFromHalfExtent)

> 

[static BoundingBox2D CreateFromHalfExtent(Vector2D center, Vector2D halfExtent)](VRageMath.BoundingBox2D.CreateFromHalfExtent)

> 

[static BoundingBox2D CreateFromPoints(IEnumerable&lt;Vector2D&gt; points)](VRageMath.BoundingBox2D.CreateFromPoints)

> Creates the smallest BoundingBox2D that will contain a group of points.

[static BoundingBox2D CreateInvalid()](VRageMath.BoundingBox2D.CreateInvalid)

> 

[static BoundingBox2D CreateMerged(BoundingBox2D original, BoundingBox2D additional)](VRageMath.BoundingBox2D.CreateMerged)

> Creates the smallest BoundingBox2D that contains the two specified BoundingBox2D instances.

[static void CreateMerged(ref BoundingBox2D original, ref BoundingBox2D additional, out BoundingBox2D result)](VRageMath.BoundingBox2D.CreateMerged)

> Creates the smallest BoundingBox2D that contains the two specified BoundingBox2D instances.

[double Area()](VRageMath.BoundingBox2D.Area)

> 

[ContainmentType Contains(BoundingBox2D box)](VRageMath.BoundingBox2D.Contains)

> Tests whether the BoundingBox2D contains another BoundingBox2D.

[void Contains(ref BoundingBox2D box, out ContainmentType result)](VRageMath.BoundingBox2D.Contains)

> Tests whether the BoundingBox2D contains a BoundingBox2D.

[ContainmentType Contains(Vector2D point)](VRageMath.BoundingBox2D.Contains)

> Tests whether the BoundingBox2D contains a point.

[void Contains(ref Vector2D point, out ContainmentType result)](VRageMath.BoundingBox2D.Contains)

> Tests whether the BoundingBox2D contains a point.

[double Distance(Vector2D point)](VRageMath.BoundingBox2D.Distance)

> 

[bool Equals(BoundingBox2D other)](VRageMath.BoundingBox2D.Equals)

> Determines whether two instances of BoundingBox2D are equal.

[bool Equals(object obj)](VRageMath.BoundingBox2D.Equals)

> Determines whether two instances of BoundingBox2D are equal.

[Vector2D&#91&#93; GetCorners()](VRageMath.BoundingBox2D.GetCorners)

> Gets an array of points that make up the corners of the BoundingBox2D.

[void GetCorners(Vector2D&#91&#93; corners)](VRageMath.BoundingBox2D.GetCorners)

> Gets the array of points that make up the corners of the BoundingBox2D.

[void GetCornersUnsafe(*Vector2D corners)](VRageMath.BoundingBox2D.GetCornersUnsafe)

> 

[int GetHashCode()](VRageMath.BoundingBox2D.GetHashCode)

> Gets the hash code for this instance.

[BoundingBox2D GetIncluded(Vector2D point)](VRageMath.BoundingBox2D.GetIncluded)

> 

[BoundingBox2D Include(ref Vector2D point)](VRageMath.BoundingBox2D.Include)

> return expanded aabb (abb include point)

[BoundingBox2D Include(Vector2D point)](VRageMath.BoundingBox2D.Include)

> 

[BoundingBox2D Include(Vector2D p0, Vector2D p1, Vector2D p2)](VRageMath.BoundingBox2D.Include)

> 

[BoundingBox2D Include(ref Vector2D p0, ref Vector2D p1, ref Vector2D p2)](VRageMath.BoundingBox2D.Include)

> 

[BoundingBox2D Include(ref BoundingBox2D box)](VRageMath.BoundingBox2D.Include)

> return expanded aabb (abb include point)

[BoundingBox2D Include(BoundingBox2D box)](VRageMath.BoundingBox2D.Include)

> 

[void Inflate(double size)](VRageMath.BoundingBox2D.Inflate)

> 

[void InflateToMinimum(Vector2D minimumSize)](VRageMath.BoundingBox2D.InflateToMinimum)

> 

[BoundingBox2D Intersect(BoundingBox2D box)](VRageMath.BoundingBox2D.Intersect)

> Returns bounding box which is intersection of this and box It's called 'Prunik' Result is invalid box when there's no intersection (Min > Max)

[bool Intersects(BoundingBox2D box)](VRageMath.BoundingBox2D.Intersects)

> Checks whether the current BoundingBox2D intersects another BoundingBox2D.

[bool Intersects(ref BoundingBox2D box)](VRageMath.BoundingBox2D.Intersects)

> 

[void Intersects(ref BoundingBox2D box, out bool result)](VRageMath.BoundingBox2D.Intersects)

> Checks whether the current BoundingBox2D intersects another BoundingBox2D.

[double Perimeter()](VRageMath.BoundingBox2D.Perimeter)

> 

[void Scale(Vector2D scale)](VRageMath.BoundingBox2D.Scale)

> 

[string ToString()](VRageMath.BoundingBox2D.ToString)

> Returns a String that represents the current BoundingBox2D.

[BoundingBox2D Translate(Vector2D vctTranlsation)](VRageMath.BoundingBox2D.Translate)

> Translate

