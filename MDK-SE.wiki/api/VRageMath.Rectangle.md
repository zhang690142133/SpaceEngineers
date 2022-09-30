← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Rectangle Struct

```csharp
public struct Rectangle: IEquatable<Rectangle>
```

Defines a rectangle.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

**Implements:**  
* [IEquatable&lt;Rectangle&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[int Height](VRageMath.Rectangle.Height)

> Specifies the height of the rectangle.

[int Width](VRageMath.Rectangle.Width)

> Specifies the width of the rectangle.

[int X](VRageMath.Rectangle.X)

> Specifies the x-coordinate of the rectangle.

[int Y](VRageMath.Rectangle.Y)

> Specifies the y-coordinate of the rectangle.

#### Properties

[int Bottom { get; }](VRageMath.Rectangle.Bottom)

> Returns the y-coordinate of the bottom of the rectangle.

[Point Center { get; }](VRageMath.Rectangle.Center)

> Gets the Point that specifies the center of the rectangle.

[int Left { get; }](VRageMath.Rectangle.Left)

> Returns the x-coordinate of the left side of the rectangle.

[Point Location { get; set; }](VRageMath.Rectangle.Location)

> Gets or sets the upper-left value of the Rectangle.

[int Right { get; }](VRageMath.Rectangle.Right)

> Returns the x-coordinate of the right side of the rectangle.

[int Top { get; }](VRageMath.Rectangle.Top)

> Returns the y-coordinate of the top of the rectangle.

#### Constructors

[Rectangle(int x, int y, int width, int height)](VRageMath.Rectangle..ctor)

> 

#### 方法

[static Rectangle Intersect(Rectangle value1, Rectangle value2)](VRageMath.Rectangle.Intersect)

> Creates a Rectangle defining the area where one rectangle overlaps with another rectangle.

[static void Intersect(ref Rectangle value1, ref Rectangle value2, out Rectangle result)](VRageMath.Rectangle.Intersect)

> Creates a Rectangle defining the area where one rectangle overlaps with another rectangle.

[static Rectangle Union(Rectangle value1, Rectangle value2)](VRageMath.Rectangle.Union)

> Creates a new Rectangle that exactly contains two other rectangles.

[static void Union(ref Rectangle value1, ref Rectangle value2, out Rectangle result)](VRageMath.Rectangle.Union)

> Creates a new Rectangle that exactly contains two other rectangles.

[bool Contains(int x, int y)](VRageMath.Rectangle.Contains)

> Determines whether this Rectangle contains a specified point represented by its x- and y-coordinates.

[bool Contains(Point value)](VRageMath.Rectangle.Contains)

> Determines whether this Rectangle contains a specified Point.

[void Contains(ref Point value, out bool result)](VRageMath.Rectangle.Contains)

> Determines whether this Rectangle contains a specified Point.

[bool Contains(Rectangle value)](VRageMath.Rectangle.Contains)

> Determines whether this Rectangle entirely contains a specified Rectangle.

[void Contains(ref Rectangle value, out bool result)](VRageMath.Rectangle.Contains)

> Determines whether this Rectangle entirely contains a specified Rectangle.

[bool Equals(Rectangle other)](VRageMath.Rectangle.Equals)

> Determines whether the specified Object is equal to the Rectangle.

[bool Equals(object obj)](VRageMath.Rectangle.Equals)

> Returns a value that indicates whether the current instance is equal to a specified object.

[int GetHashCode()](VRageMath.Rectangle.GetHashCode)

> Gets the hash code for this object.

[void Inflate(int horizontalAmount, int verticalAmount)](VRageMath.Rectangle.Inflate)

> Pushes the edges of the Rectangle out by the horizontal and vertical values specified.

[bool Intersects(Rectangle value)](VRageMath.Rectangle.Intersects)

> Determines whether a specified Rectangle intersects with this Rectangle.

[void Intersects(ref Rectangle value, out bool result)](VRageMath.Rectangle.Intersects)

> Determines whether a specified Rectangle intersects with this Rectangle.

[void Offset(Point amount)](VRageMath.Rectangle.Offset)

> Changes the position of the Rectangle.

[void Offset(int offsetX, int offsetY)](VRageMath.Rectangle.Offset)

> Changes the position of the Rectangle.

[string ToString()](VRageMath.Rectangle.ToString)

> Retrieves a string representation of the current object.

