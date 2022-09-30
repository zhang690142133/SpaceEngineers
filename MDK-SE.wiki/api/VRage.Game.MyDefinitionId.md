← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyDefinitionId Struct

```csharp
public struct MyDefinitionId: IEquatable<MyDefinitionId>
```

Prefer getting definition ID using object builder used to create the item. If you have automatic rifle, in its Init method create new MyDefinitionId using TypeId and SubtypeName of object builder. Do not write specific values in code, as data comes from XML and if those change, code needs to change as well.

**命名空间:** [VRage.Game](VRage.Game)  
**Assembly:** VRage.Game.dll

**Implements:**  
* [IEquatable&lt;MyDefinitionId&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[static DefinitionIdComparerType Comparer](VRage.Game.MyDefinitionId.Comparer)

> 

[MyStringHash SubtypeId](VRage.Game.MyDefinitionId.SubtypeId)

> 

[MyObjectBuilderType TypeId](VRage.Game.MyDefinitionId.TypeId)

> 

#### Properties

[string SubtypeName { get; }](VRage.Game.MyDefinitionId.SubtypeName)

> 

#### Constructors

[MyDefinitionId(MyObjectBuilderType type)](VRage.Game.MyDefinitionId..ctor)

> 

[MyDefinitionId(MyObjectBuilderType type, string subtypeName)](VRage.Game.MyDefinitionId..ctor)

> 

[MyDefinitionId(MyObjectBuilderType type, MyStringHash subtypeId)](VRage.Game.MyDefinitionId..ctor)

> 

[MyDefinitionId(MyRuntimeObjectBuilderId type, MyStringHash subtypeId)](VRage.Game.MyDefinitionId..ctor)

> 

#### 方法

[static MyDefinitionId FromContent(MyObjectBuilder_Base content)](VRage.Game.MyDefinitionId.FromContent)

> Creates a new definition ID from a given content.

[static MyDefinitionId Parse(string id)](VRage.Game.MyDefinitionId.Parse)

> Attempts to create a definition ID from a definition string, which has the form (using ores as an example) "MyObjectBuilder_Ore/Iron". The first part must represent an existing type. If it does not, an exception will be thrown. The second (the subtype) is not enforced. See TryParse for a parsing method that does not throw an exception.

[static bool TryParse(string id, out MyDefinitionId definitionId)](VRage.Game.MyDefinitionId.TryParse)

> Attempts to create a definition ID from a definition string, which has the form (using ores as an example) "MyObjectBuilder_Ore/Iron". The first part must represent an existing type, while the second (the subtype) is not enforced.

[static bool TryParse(string type, string subtype, out MyDefinitionId definitionId)](VRage.Game.MyDefinitionId.TryParse)

> 

[bool Equals(object obj)](VRage.Game.MyDefinitionId.Equals)

> 

[bool Equals(MyDefinitionId other)](VRage.Game.MyDefinitionId.Equals)

> 

[int GetHashCode()](VRage.Game.MyDefinitionId.GetHashCode)

> 

[long GetHashCodeLong()](VRage.Game.MyDefinitionId.GetHashCodeLong)

> Safer hash code. It is unique in more situations than GetHashCode would be, but it may still require full check.

[string ToString()](VRage.Game.MyDefinitionId.ToString)

> 

