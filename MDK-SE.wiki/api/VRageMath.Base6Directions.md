← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Base6Directions Class

```csharp
public class Base6Directions
```

Workaround because .NET XML serializer is stupid and does not like enum inside static class

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[static Vector3&#91&#93; Directions](VRageMath.Base6Directions.Directions)

> 

[static Direction&#91&#93; EnumDirections](VRageMath.Base6Directions.EnumDirections)

> Because Enum.GetValues(...) returns array of objects

[static Vector3I&#91&#93; IntDirections](VRageMath.Base6Directions.IntDirections)

> 

#### 方法

[static Axis GetAxis(Direction direction)](VRageMath.Base6Directions.GetAxis)

> 

[static Direction GetBaseAxisDirection(Axis axis)](VRageMath.Base6Directions.GetBaseAxisDirection)

> 

[static Direction GetClosestDirection(Vector3 vec)](VRageMath.Base6Directions.GetClosestDirection)

> 

[static Direction GetClosestDirection(ref Vector3 vec)](VRageMath.Base6Directions.GetClosestDirection)

> 

[static Direction GetCross(Direction dir1, Direction dir2)](VRageMath.Base6Directions.GetCross)

> 

[static Direction GetDirection(Vector3 vec)](VRageMath.Base6Directions.GetDirection)

> 

[static Direction GetDirection(ref Vector3 vec)](VRageMath.Base6Directions.GetDirection)

> 

[static Direction GetDirection(Vector3I vec)](VRageMath.Base6Directions.GetDirection)

> 

[static Direction GetDirection(ref Vector3I vec)](VRageMath.Base6Directions.GetDirection)

> 

[static DirectionFlags GetDirectionFlag(Direction dir)](VRageMath.Base6Directions.GetDirectionFlag)

> 

[static Direction GetDirectionInAxis(Vector3 vec, Axis axis)](VRageMath.Base6Directions.GetDirectionInAxis)

> 

[static Direction GetDirectionInAxis(ref Vector3 vec, Axis axis)](VRageMath.Base6Directions.GetDirectionInAxis)

> 

[static Direction GetFlippedDirection(Direction toFlip)](VRageMath.Base6Directions.GetFlippedDirection)

> 

[static Direction GetForward(Quaternion rot)](VRageMath.Base6Directions.GetForward)

> 

[static Direction GetForward(ref Quaternion rot)](VRageMath.Base6Directions.GetForward)

> 

[static Direction GetForward(ref Matrix rotation)](VRageMath.Base6Directions.GetForward)

> 

[static Vector3I GetIntVector(int direction)](VRageMath.Base6Directions.GetIntVector)

> 

[static Vector3I GetIntVector(Direction dir)](VRageMath.Base6Directions.GetIntVector)

> 

[static Direction GetLeft(Direction up, Direction forward)](VRageMath.Base6Directions.GetLeft)

> 

[static Direction GetOppositeDirection(Direction dir)](VRageMath.Base6Directions.GetOppositeDirection)

> 

[static Quaternion GetOrientation(Direction forward, Direction up)](VRageMath.Base6Directions.GetOrientation)

> 

[static Direction GetPerpendicular(Direction dir)](VRageMath.Base6Directions.GetPerpendicular)

> 

[static Direction GetUp(Quaternion rot)](VRageMath.Base6Directions.GetUp)

> 

[static Direction GetUp(ref Quaternion rot)](VRageMath.Base6Directions.GetUp)

> 

[static Direction GetUp(ref Matrix rotation)](VRageMath.Base6Directions.GetUp)

> 

[static Vector3 GetVector(int direction)](VRageMath.Base6Directions.GetVector)

> 

[static Vector3 GetVector(Direction dir)](VRageMath.Base6Directions.GetVector)

> 

[static void GetVector(Direction dir, out Vector3 result)](VRageMath.Base6Directions.GetVector)

> 

[static bool IsBaseDirection(ref Vector3 vec)](VRageMath.Base6Directions.IsBaseDirection)

> 

[static bool IsBaseDirection(Vector3 vec)](VRageMath.Base6Directions.IsBaseDirection)

> 

[static bool IsBaseDirection(ref Vector3I vec)](VRageMath.Base6Directions.IsBaseDirection)

> 

[static bool IsValidBlockOrientation(Direction forward, Direction up)](VRageMath.Base6Directions.IsValidBlockOrientation)

> 

