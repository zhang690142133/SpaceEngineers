← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### UpdateFrequency Enum

```csharp
public enum UpdateFrequency
```

Flags set how often the script will run itself.

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

#### Fields

UpdateFrequency None

> Does not run autonomously.

UpdateFrequency Once

> Run once before the next tick. Flag is un-set automatically after the update

UpdateFrequency Update1

> Run every game tick.

UpdateFrequency Update10

> Run every 10th game tick.

UpdateFrequency Update100

> Run every 100th game tick.

