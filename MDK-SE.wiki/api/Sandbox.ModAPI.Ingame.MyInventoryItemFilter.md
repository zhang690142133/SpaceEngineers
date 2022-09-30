← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyInventoryItemFilter Struct

```csharp
public struct MyInventoryItemFilter
```

Implements inventory item filter

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

#### Fields

[bool AllSubTypes](Sandbox.ModAPI.Ingame.MyInventoryItemFilter.AllSubTypes)

> Determines whether all subtypes of the given item ID should pass this filter check.

[MyDefinitionId ItemId](Sandbox.ModAPI.Ingame.MyInventoryItemFilter.ItemId)

> Specifies an item to filter. Set [AllSubTypes](Sandbox.ModAPI.Ingame.MyInventoryItemFilter.AllSubTypes) to true to only check the main type part of this ID.

#### Properties

[MyItemType ItemType { get; }](Sandbox.ModAPI.Ingame.MyInventoryItemFilter.ItemType)

> 

#### Constructors

[MyInventoryItemFilter(string itemId, bool allSubTypes = default)](Sandbox.ModAPI.Ingame.MyInventoryItemFilter..ctor)

> 

[MyInventoryItemFilter(MyDefinitionId itemId, bool allSubTypes = default)](Sandbox.ModAPI.Ingame.MyInventoryItemFilter..ctor)

> 

