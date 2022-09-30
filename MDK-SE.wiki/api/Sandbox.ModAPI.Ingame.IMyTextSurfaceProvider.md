← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### IMyTextSurfaceProvider Interface

```csharp
public interface IMyTextSurfaceProvider
```

Describes block, that has at least 1 text surface (PB scripting interface)

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

**Inheritors:**  
* [IMyCockpit](Sandbox.ModAPI.Ingame.IMyCockpit)  
* [IMyCryoChamber](Sandbox.ModAPI.Ingame.IMyCryoChamber)  
* [IMyProgrammableBlock](Sandbox.ModAPI.Ingame.IMyProgrammableBlock)  
* [IMyProjector](Sandbox.ModAPI.Ingame.IMyProjector)

#### Properties

[int SurfaceCount { get; }](Sandbox.ModAPI.Ingame.IMyTextSurfaceProvider.SurfaceCount)

> Get surfaces count

[bool UseGenericLcd { get; }](Sandbox.ModAPI.Ingame.IMyTextSurfaceProvider.UseGenericLcd)

> Whether generic LCD terminal controls should be created

#### 方法

[IMyTextSurface GetSurface(int index)](Sandbox.ModAPI.Ingame.IMyTextSurfaceProvider.GetSurface)

> Get surface by index

