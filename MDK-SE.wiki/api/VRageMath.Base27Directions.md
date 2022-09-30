← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### Base27Directions Class

```csharp
public class Base27Directions
```

Base 26 directions and Vector3.Zero Each component is only 0,-1 or 1;

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[static Vector3&#91&#93; Directions](VRageMath.Base27Directions.Directions)

> 

[static Vector3I&#91&#93; DirectionsInt](VRageMath.Base27Directions.DirectionsInt)

> 

#### Constructors

[Base27Directions()](VRageMath.Base27Directions..ctor)

> 

#### 方法

[static Direction GetDirection(Vector3 vec)](VRageMath.Base27Directions.GetDirection)

> Vector must be normalized, allowed values for components are: 0, 1, -1, 0.707, -0.707, 0.577, -0.577

[static Direction GetDirection(Vector3I vec)](VRageMath.Base27Directions.GetDirection)

> 

[static Direction GetDirection(ref Vector3 vec)](VRageMath.Base27Directions.GetDirection)

> 

[static Direction GetDirection(ref Vector3I vec)](VRageMath.Base27Directions.GetDirection)

> 

[static Direction GetForward(ref Quaternion rot)](VRageMath.Base27Directions.GetForward)

> 

[static Direction GetUp(ref Quaternion rot)](VRageMath.Base27Directions.GetUp)

> 

[static Vector3 GetVector(int direction)](VRageMath.Base27Directions.GetVector)

> 

[static Vector3 GetVector(Direction dir)](VRageMath.Base27Directions.GetVector)

> 

[static Vector3I GetVectorInt(int direction)](VRageMath.Base27Directions.GetVectorInt)

> 

[static Vector3I GetVectorInt(Direction dir)](VRageMath.Base27Directions.GetVectorInt)

> 

[static bool IsBaseDirection(ref Vector3 vec)](VRageMath.Base27Directions.IsBaseDirection)

> 

[static bool IsBaseDirection(ref Vector3I vec)](VRageMath.Base27Directions.IsBaseDirection)

> 

[static bool IsBaseDirection(Vector3 vec)](VRageMath.Base27Directions.IsBaseDirection)

> 

