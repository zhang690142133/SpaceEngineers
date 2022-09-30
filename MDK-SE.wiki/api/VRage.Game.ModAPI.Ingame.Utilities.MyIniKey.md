← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyIniKey Struct

```csharp
public struct MyIniKey: IEquatable<MyIniKey>
```

Represents the combination of a section and a key in a [MyIni](VRage.Game.ModAPI.Ingame.Utilities.MyIni) structure.

**命名空间:** [VRage.Game.ModAPI.Ingame.Utilities](VRage.Game.ModAPI.Ingame.Utilities)  
**Assembly:** VRage.Game.dll

**Implements:**  
* [IEquatable&lt;MyIniKey&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static MyIniKey EMPTY](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.EMPTY)

> 

#### Properties

[bool IsEmpty { get; }](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.IsEmpty)

> Determines whether this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) is empty.

[string Name { get; }](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.Name)

> Gets the Key part of this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) 

[string Section { get; }](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.Section)

> Gets the Section part of this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) 

#### Constructors

[MyIniKey(string section, string name)](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey..ctor)

> 

#### 方法

[static MyIniKey Parse(string input)](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.Parse)

> Parses a string in the form of`section/key`into a [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) object.

[static bool TryParse(string input, out MyIniKey key)](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.TryParse)

> Parses a string in the form of`section/key`into a [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) object.

[bool Equals(MyIniKey other)](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.Equals)

> Compares this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) with another. Note that this is equality in the sense of a configuration key, which means the comparison is implicitly case insensitive.

[bool Equals(object obj)](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.Equals)

> Compares this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) with another. Note that this is equality in the sense of a configuration key, which means the comparison is implicitly case insensitive.

[int GetHashCode()](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.GetHashCode)

> Gets the hash code representing this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) 

[string ToString()](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.ToString)

> Generates a string representing this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) in the form of`section/key`.

