← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [MyWaypointInfo](Sandbox.ModAPI.Ingame.MyWaypointInfo)

### 概要

```csharp
public static bool TryParse(string text, out MyWaypointInfo gps)
```

Attempts to parse a GPS coordinate from the given text. The text cannot contain anything but the GPS coordinate.  
  
A GPS coordinate has the format GPS:Name:X:Y:Z:

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



### 参数

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) text
* [MyWaypointInfo](Sandbox.ModAPI.Ingame.MyWaypointInfo) gps
