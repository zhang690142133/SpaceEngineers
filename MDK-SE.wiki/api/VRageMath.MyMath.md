← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyMath Class

```csharp
public abstract sealed class MyMath
```

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[static Vector3 Vector3One](VRageMath.MyMath.Vector3One)

> 

#### 方法

[static Vector3 Abs(ref Vector3 vector)](VRageMath.MyMath.Abs)

> 

[static float AngleBetween(Vector3 a, Vector3 b)](VRageMath.MyMath.AngleBetween)

> 

[static Vector3 AngleTo(Vector3 From, Vector3 Location)](VRageMath.MyMath.AngleTo)

> AngleTo

[static float ArcTanAngle(float x, float y)](VRageMath.MyMath.ArcTanAngle)

> ArcTanAngle

[static float Clamp(float val, float min, float max)](VRageMath.MyMath.Clamp)

> 

[static float CosineDistance(ref Vector3 a, ref Vector3 b)](VRageMath.MyMath.CosineDistance)

> 

[static double CosineDistance(ref Vector3D a, ref Vector3D b)](VRageMath.MyMath.CosineDistance)

> 

[static BoundingBox CreateFromInsideRadius(float radius)](VRageMath.MyMath.CreateFromInsideRadius)

> 

[static float DistanceSquaredFromLineSegment(Vector3 v, Vector3 w, Vector3 p)](VRageMath.MyMath.DistanceSquaredFromLineSegment)

> Return minimum distance between line segment v-w and point p.

[static float FastCos(float angle)](VRageMath.MyMath.FastCos)

> 

[static float FastSin(float angle)](VRageMath.MyMath.FastSin)

> 

[static float FastTanH(float x)](VRageMath.MyMath.FastTanH)

> Fast approximation of Hyperbolic tangent Max deviation is <3%

[static Vector3 ForwardVectorProjection(Vector3 forwardVector, Vector3 projectedVector)](VRageMath.MyMath.ForwardVectorProjection)

> This projection results to initial velocity of non-engine objects, which parents move in some velocity We want to add only forward speed of the parent to the forward direction of the object, and if parent is going backward, no speed is added.

[static void InitializeFastSin()](VRageMath.MyMath.InitializeFastSin)

> 

[static Vector3 MaxComponents(ref Vector3 a, ref Vector3 b)](VRageMath.MyMath.MaxComponents)

> Return vector with each component max

[static int Mod(int x, int m)](VRageMath.MyMath.Mod)

> 

[static long Mod(long x, int m)](VRageMath.MyMath.Mod)

> 

[static float NormalizeAngle(float angle, float center = 0)](VRageMath.MyMath.NormalizeAngle)

> 

[static Vector3 QuaternionToEuler(Quaternion Rotation)](VRageMath.MyMath.QuaternionToEuler)

> QuaternionToEuler

[static Vector3 VectorFromColor(byte red, byte green, byte blue)](VRageMath.MyMath.VectorFromColor)

> Calculates color from vector

[static Vector4 VectorFromColor(byte red, byte green, byte blue, byte alpha)](VRageMath.MyMath.VectorFromColor)

> 

