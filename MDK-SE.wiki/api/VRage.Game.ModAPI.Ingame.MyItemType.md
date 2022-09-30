← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyItemType Struct

```csharp
public struct MyItemType: IComparable<MyItemType>, IEquatable<MyItemType>
```

Use by [MyInventoryItem](VRage.Game.ModAPI.Ingame.MyInventoryItem) 

**命名空间:** [VRage.Game.ModAPI.Ingame](VRage.Game.ModAPI.Ingame)  
**Assembly:** VRage.Game.dll

**Implements:**  
* [IComparable&lt;MyItemType&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netframework-4.6)  
* [IEquatable&lt;MyItemType&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Properties

[string SubtypeId { get; }](VRage.Game.ModAPI.Ingame.MyItemType.SubtypeId)

> Gets Subtype of Item

[string TypeId { get; }](VRage.Game.ModAPI.Ingame.MyItemType.TypeId)

> Gets TypeId of Item

#### Constructors

[MyItemType(string typeId, string subtypeId)](VRage.Game.ModAPI.Ingame.MyItemType..ctor)

> 

[MyItemType(MyObjectBuilderType typeId, MyStringHash subTypeIdHash)](VRage.Game.ModAPI.Ingame.MyItemType..ctor)

> 

#### 方法

[static MyItemType MakeAmmo(string subTypeId)](VRage.Game.ModAPI.Ingame.MyItemType.MakeAmmo)

> 

[static MyItemType MakeComponent(string subTypeId)](VRage.Game.ModAPI.Ingame.MyItemType.MakeComponent)

> 

[static MyItemType MakeIngot(string subTypeId)](VRage.Game.ModAPI.Ingame.MyItemType.MakeIngot)

> 

[static MyItemType MakeOre(string subTypeId)](VRage.Game.ModAPI.Ingame.MyItemType.MakeOre)

> 

[static MyItemType MakeTool(string subTypeId)](VRage.Game.ModAPI.Ingame.MyItemType.MakeTool)

> 

[static MyItemType Parse(string itemType)](VRage.Game.ModAPI.Ingame.MyItemType.Parse)

> 

[int CompareTo(MyItemType other)](VRage.Game.ModAPI.Ingame.MyItemType.CompareTo)

> 

[bool Equals(MyItemType other)](VRage.Game.ModAPI.Ingame.MyItemType.Equals)

> 

[bool Equals(object obj)](VRage.Game.ModAPI.Ingame.MyItemType.Equals)

> 

[int GetHashCode()](VRage.Game.ModAPI.Ingame.MyItemType.GetHashCode)

> 

[string ToString()](VRage.Game.ModAPI.Ingame.MyItemType.ToString)

> 

