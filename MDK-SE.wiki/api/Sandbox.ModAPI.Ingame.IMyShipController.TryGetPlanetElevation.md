← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)

### 概要

```csharp
public bool TryGetPlanetElevation(MyPlanetElevation detail, out double elevation)
```

Attempts to get the elevation of the ship in relation to the nearest planet. This method is only available when a ship is within the gravity well of a planet.

### 返回

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if cockpit is in planet gravity

### 参数

* [MyPlanetElevation](Sandbox.ModAPI.Ingame.MyPlanetElevation) detail
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) elevation
