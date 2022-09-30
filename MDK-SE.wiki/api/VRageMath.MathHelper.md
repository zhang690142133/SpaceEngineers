← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MathHelper Class

```csharp
public abstract sealed class MathHelper
```

Contains commonly used precalculated values.

**命名空间:** [VRageMath](VRageMath)  
**Assembly:** VRage.Math.dll

#### Fields

[static float E](VRageMath.MathHelper.E)

> Represents the mathematical constant e.

[static float EPSILON](VRageMath.MathHelper.EPSILON)

> 

[static float EPSILON10](VRageMath.MathHelper.EPSILON10)

> 

[static float FourPi](VRageMath.MathHelper.FourPi)

> Represents the value of pi times two.

[static float Log10E](VRageMath.MathHelper.Log10E)

> Represents the log base ten of e.

[static float Log2E](VRageMath.MathHelper.Log2E)

> Represents the log base two of e.

[static float Pi](VRageMath.MathHelper.Pi)

> Represents the value of pi.

[static float PiOver2](VRageMath.MathHelper.PiOver2)

> Represents the value of pi divided by two.

[static float PiOver4](VRageMath.MathHelper.PiOver4)

> Represents the value of pi divided by four.

[static float RadiansPerSecondToRPM](VRageMath.MathHelper.RadiansPerSecondToRPM)

> 60 / 2*pi

[static float RPMToRadiansPerMillisec](VRageMath.MathHelper.RPMToRadiansPerMillisec)

> 2*pi / 60000

[static float RPMToRadiansPerSecond](VRageMath.MathHelper.RPMToRadiansPerSecond)

> 2*pi / 60

[static float Sqrt2](VRageMath.MathHelper.Sqrt2)

> Represents the value of the square root of two

[static float Sqrt3](VRageMath.MathHelper.Sqrt3)

> Represents the value of the square root of three

[static float TwoPi](VRageMath.MathHelper.TwoPi)

> Represents the value of pi times two.

#### 方法

[static int Align(int value, int alignment)](VRageMath.MathHelper.Align)

> 

[static float Atan(float x)](VRageMath.MathHelper.Atan)

> Faster Atan implementation. Good only in the [-pi/2, pi/2] range.

[static double Atan(double x)](VRageMath.MathHelper.Atan)

> Faster Atan implementation. Good only in the [-pi/2, pi/2] range.

[static float Barycentric(float value1, float value2, float value3, float amount1, float amount2)](VRageMath.MathHelper.Barycentric)

> Returns the Cartesian coordinate for one axis of a point that is defined by a given triangle and two normalized barycentric (areal) coordinates.

[static Vector3D CalculateBezierPoint(double t, Vector3D p0, Vector3D p1, Vector3D p2, Vector3D p3)](VRageMath.MathHelper.CalculateBezierPoint)

> 

[static Vector3 CalculateVectorOnSphere(Vector3 northPoleDir, float phi, float theta)](VRageMath.MathHelper.CalculateVectorOnSphere)

> 

[static float CatmullRom(float value1, float value2, float value3, float value4, float amount)](VRageMath.MathHelper.CatmullRom)

> Performs a Catmull-Rom interpolation using the specified positions.

[static int CeilToInt(float x)](VRageMath.MathHelper.CeilToInt)

> 

[static int CeilToInt(double x)](VRageMath.MathHelper.CeilToInt)

> 

[static float Clamp(float value, float min, float max)](VRageMath.MathHelper.Clamp)

> Restricts a value to be within a specified range. Reference page contains links to related code samples.

[static double Clamp(double value, double min, double max)](VRageMath.MathHelper.Clamp)

> Restricts a value to be within a specified range. Reference page contains links to related code samples.

[static MyFixedPoint Clamp(MyFixedPoint value, MyFixedPoint min, MyFixedPoint max)](VRageMath.MathHelper.Clamp)

> Restricts a value to be within a specified range. Reference page contains links to related code samples.

[static int Clamp(int value, int min, int max)](VRageMath.MathHelper.Clamp)

> Restricts a value to be within a specified range. Reference page contains links to related code samples.

[static int ComputeHashFromBytes(Byte&#91&#93; bytes)](VRageMath.MathHelper.ComputeHashFromBytes)

> 

[static double CubicInterp(double p0, double p1, double p2, double p3, double t)](VRageMath.MathHelper.CubicInterp)

> 

[static float Distance(float value1, float value2)](VRageMath.MathHelper.Distance)

> Calculates the absolute value of the difference of two values.

[static int Floor(float n)](VRageMath.MathHelper.Floor)

> 

[static int Floor(double n)](VRageMath.MathHelper.Floor)

> 

[static int FloorToInt(float x)](VRageMath.MathHelper.FloorToInt)

> 

[static int FloorToInt(double x)](VRageMath.MathHelper.FloorToInt)

> 

[static int GetNearestBiggerPowerOfTwo(int v)](VRageMath.MathHelper.GetNearestBiggerPowerOfTwo)

> 

[static uint GetNearestBiggerPowerOfTwo(uint v)](VRageMath.MathHelper.GetNearestBiggerPowerOfTwo)

> 

[static int GetNearestBiggerPowerOfTwo(float f)](VRageMath.MathHelper.GetNearestBiggerPowerOfTwo)

> Returns nearest bigger power of two

[static int GetNearestBiggerPowerOfTwo(double f)](VRageMath.MathHelper.GetNearestBiggerPowerOfTwo)

> 

[static int GetNumberOfMipmaps(int v)](VRageMath.MathHelper.GetNumberOfMipmaps)

> 

[static float Hermite(float value1, float tangent1, float value2, float tangent2, float amount)](VRageMath.MathHelper.Hermite)

> Performs a Hermite spline interpolation.

[static float InterpLog(float value, float amount1, float amount2)](VRageMath.MathHelper.InterpLog)

> Performs interpolation on logarithmic scale.

[static float InterpLogInv(float value, float amount1, float amount2)](VRageMath.MathHelper.InterpLogInv)

> 

[static bool IsEqual(float value1, float value2)](VRageMath.MathHelper.IsEqual)

> 

[static bool IsEqual(Vector2 value1, Vector2 value2)](VRageMath.MathHelper.IsEqual)

> 

[static bool IsEqual(Vector3 value1, Vector3 value2)](VRageMath.MathHelper.IsEqual)

> 

[static bool IsEqual(Quaternion value1, Quaternion value2)](VRageMath.MathHelper.IsEqual)

> 

[static bool IsEqual(QuaternionD value1, QuaternionD value2)](VRageMath.MathHelper.IsEqual)

> 

[static bool IsEqual(Matrix value1, Matrix value2)](VRageMath.MathHelper.IsEqual)

> 

[static bool IsPowerOfTwo(int x)](VRageMath.MathHelper.IsPowerOfTwo)

> Returns true if value is power of two

[static bool IsValid(Matrix matrix)](VRageMath.MathHelper.IsValid)

> 

[static bool IsValid(MatrixD matrix)](VRageMath.MathHelper.IsValid)

> 

[static bool IsValid(Vector3 vec)](VRageMath.MathHelper.IsValid)

> 

[static bool IsValid(Vector3D vec)](VRageMath.MathHelper.IsValid)

> 

[static bool IsValid(Vector2 vec)](VRageMath.MathHelper.IsValid)

> 

[static bool IsValid(float f)](VRageMath.MathHelper.IsValid)

> 

[static bool IsValid(double f)](VRageMath.MathHelper.IsValid)

> 

[static bool IsValid(Vector3? vec)](VRageMath.MathHelper.IsValid)

> 

[static bool IsValid(Quaternion q)](VRageMath.MathHelper.IsValid)

> 

[static bool IsValidNormal(Vector3 vec)](VRageMath.MathHelper.IsValidNormal)

> 

[static bool IsValidOrZero(Matrix matrix)](VRageMath.MathHelper.IsValidOrZero)

> 

[static bool IsZero(float value, float epsilon = 1E-05)](VRageMath.MathHelper.IsZero)

> 

[static bool IsZero(double value, float epsilon = 1E-05)](VRageMath.MathHelper.IsZero)

> 

[static bool IsZero(Vector3 value, float epsilon = 1E-05)](VRageMath.MathHelper.IsZero)

> 

[static bool IsZero(Vector3D value, float epsilon = 1E-05)](VRageMath.MathHelper.IsZero)

> 

[static bool IsZero(Quaternion value, float epsilon = 1E-05)](VRageMath.MathHelper.IsZero)

> 

[static bool IsZero(Vector4 value)](VRageMath.MathHelper.IsZero)

> 

[static float Lerp(float value1, float value2, float amount)](VRageMath.MathHelper.Lerp)

> Linearly interpolates between two values.

[static double Lerp(double value1, double value2, double amount)](VRageMath.MathHelper.Lerp)

> Linearly interpolates between two values.

[static void LimitRadians(ref float angle)](VRageMath.MathHelper.LimitRadians)

> Returns angle in range 0..2*PI

[static void LimitRadians2PI(ref double angle)](VRageMath.MathHelper.LimitRadians2PI)

> Returns angle in range 0..2*PI

[static void LimitRadiansPI(ref double angle)](VRageMath.MathHelper.LimitRadiansPI)

> Returns angle in range -PI..PI

[static void LimitRadiansPI(ref float angle)](VRageMath.MathHelper.LimitRadiansPI)

> Returns angle in range -PI..PI

[static int Log2(int n)](VRageMath.MathHelper.Log2)

> 

[static int Log2(uint n)](VRageMath.MathHelper.Log2)

> 

[static int Log2Ceiling(int value)](VRageMath.MathHelper.Log2Ceiling)

> 

[static int Log2Floor(int value)](VRageMath.MathHelper.Log2Floor)

> 

[static float Max(float value1, float value2)](VRageMath.MathHelper.Max)

> Returns the greater of two values.

[static double Max(double value1, double value2)](VRageMath.MathHelper.Max)

> Returns the greater of two values.

[static float Max(float a, float b, float c)](VRageMath.MathHelper.Max)

> 

[static int Max(int a, int b, int c)](VRageMath.MathHelper.Max)

> 

[static double Max(double a, double b, double c)](VRageMath.MathHelper.Max)

> 

[static float Min(float value1, float value2)](VRageMath.MathHelper.Min)

> Returns the lesser of two values.

[static double Min(double value1, double value2)](VRageMath.MathHelper.Min)

> Returns the lesser of two values.

[static float Min(float a, float b, float c)](VRageMath.MathHelper.Min)

> 

[static double Min(double a, double b, double c)](VRageMath.MathHelper.Min)

> 

[static float MonotonicAcos(float cos)](VRageMath.MathHelper.MonotonicAcos)

> 

[static float MonotonicCosine(float radians)](VRageMath.MathHelper.MonotonicCosine)

> Calculate the monotonic cosine of a value. Monotonic cosine is an alternative cosine encoding that is monotonic in the [-pi, pi] interval. We use this when some parameter of an onject in a planet is constrained by latitude. The 'monotonicity' is guaranteed by subtracting the cosine value from 2 if the angle is positive. So for instance MonotonicCos(pi/2) = 2. This only works in the above interval of course.

[static int Pow2(int n)](VRageMath.MathHelper.Pow2)

> Returns 2^n

[static float RoundOn2(float x)](VRageMath.MathHelper.RoundOn2)

> 

[static int RoundToInt(float x)](VRageMath.MathHelper.RoundToInt)

> 

[static int RoundToInt(double x)](VRageMath.MathHelper.RoundToInt)

> 

[static float Saturate(float n)](VRageMath.MathHelper.Saturate)

> 

[static double Saturate(double n)](VRageMath.MathHelper.Saturate)

> 

[static float SCurve3(float t)](VRageMath.MathHelper.SCurve3)

> 

[static double SCurve3(double t)](VRageMath.MathHelper.SCurve3)

> 

[static float SCurve5(float t)](VRageMath.MathHelper.SCurve5)

> 

[static double SCurve5(double t)](VRageMath.MathHelper.SCurve5)

> 

[static int Smooth(int newValue, int lastSmooth)](VRageMath.MathHelper.Smooth)

> 

[static float Smooth(float newValue, float lastSmooth)](VRageMath.MathHelper.Smooth)

> 

[static float SmoothStep(float value1, float value2, float amount)](VRageMath.MathHelper.SmoothStep)

> Interpolates between two values using a cubic equation.

[static double SmoothStep(double value1, double value2, double amount)](VRageMath.MathHelper.SmoothStep)

> Interpolates between two values using a cubic equation.

[static float SmoothStepStable(float amount)](VRageMath.MathHelper.SmoothStepStable)

> Interpolates between zero and one using cubic equiation, solved by de Casteljau.

[static double SmoothStepStable(double amount)](VRageMath.MathHelper.SmoothStepStable)

> Interpolates between zero and one using cubic equiation, solved by de Casteljau.

[static float ToDegrees(float radians)](VRageMath.MathHelper.ToDegrees)

> Converts radians to degrees.

[static double ToDegrees(double radians)](VRageMath.MathHelper.ToDegrees)

> 

[static float ToRadians(float degrees)](VRageMath.MathHelper.ToRadians)

> Converts degrees to radians.

[static Vector3 ToRadians(Vector3 v)](VRageMath.MathHelper.ToRadians)

> 

[static double ToRadians(double degrees)](VRageMath.MathHelper.ToRadians)

> Converts degrees to radians.

[static float WrapAngle(float angle)](VRageMath.MathHelper.WrapAngle)

> Reduces a given angle to a value between π and -π.

