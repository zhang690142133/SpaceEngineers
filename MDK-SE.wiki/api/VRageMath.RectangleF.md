← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### RectangleF Struct

```csharp
public struct RectangleF: IEquatable<RectangleF>
```

Structure using the same layout than [System.Drawing.RectangleF](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef?view=netframework-4.6) 

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;RectangleF&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[Vector2 Position](VRageMath.RectangleF.Position)

> The Position.

[Vector2 Size](VRageMath.RectangleF.Size)

> The Size.

#### Properties

[float Bottom { get; }](VRageMath.RectangleF.Bottom)

> 

[Vector2 Center { get; }](VRageMath.RectangleF.Center)

> 

[float Height { get; set; }](VRageMath.RectangleF.Height)

> Height of this rectangle.

[float Right { get; }](VRageMath.RectangleF.Right)

> 

[float Width { get; set; }](VRageMath.RectangleF.Width)

> Width of this rectangle.

[float X { get; set; }](VRageMath.RectangleF.X)

> Left coordinate.

[float Y { get; set; }](VRageMath.RectangleF.Y)

> Top coordinate.

#### Constructors

[RectangleF(Vector2 position, Vector2 size)](VRageMath.RectangleF..ctor)

> 

[RectangleF(float x, float y, float width, float height)](VRageMath.RectangleF..ctor)

> 

#### 方法

[static bool Intersect(ref RectangleF value1, ref RectangleF value2, out RectangleF result)](VRageMath.RectangleF.Intersect)

> Creates a Rectangle defining the area where one rectangle overlaps with another rectangle.

[static RectangleF Min(RectangleF? rectangle, RectangleF? scissors)](VRageMath.RectangleF.Min)

> 

[bool Contains(int x, int y)](VRageMath.RectangleF.Contains)

> 

[bool Contains(float x, float y)](VRageMath.RectangleF.Contains)

> 

[bool Contains(Vector2 vector2D)](VRageMath.RectangleF.Contains)

> 

[bool Contains(Point point)](VRageMath.RectangleF.Contains)

> 

[bool Equals(RectangleF other)](VRageMath.RectangleF.Equals)

> Equals to other rectangle

[bool Equals(object obj)](VRageMath.RectangleF.Equals)

> 

[int GetHashCode()](VRageMath.RectangleF.GetHashCode)

> 

[string ToString()](VRageMath.RectangleF.ToString)

> 

