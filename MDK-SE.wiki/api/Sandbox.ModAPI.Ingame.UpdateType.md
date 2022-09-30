← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### UpdateType Enum

```csharp
public enum UpdateType
```

Enum describes what source triggered the script to run.

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

#### Fields

UpdateType IGC

> Script run by intergrid communication system.

UpdateType Mod

> Script run by a mod.

UpdateType None

> None

UpdateType Once

> Script is updating once before the tick.

UpdateType Script

> Script run by another programmable block.

UpdateType Terminal

> Script run by user in the terminal.

UpdateType Trigger

> Script run by a block such as timer, sensor.

UpdateType Update1

> Script is updating every tick.

UpdateType Update10

> Script is updating every 10th tick.

UpdateType Update100

> Script is updating every 100th tick.

