← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyResourceSourceComponent 类

```csharp
public class MyResourceSourceComponent: MyResourceSourceComponentBase
```

**命名空间:** [Sandbox.Game.EntityComponents](Sandbox.Game.EntityComponents)  
**Assembly:** Sandbox.Game.dll

**继承:**   MyEntityComponentBase <sub>prohibited</sub> ˃ [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)

#### 方法
[CurrentOutputByType](VRage.Game.Components.MyResourceSourceComponentBase.CurrentOutputByType)
```csharp
//当前输出功率,单位 MW/h或者升/h.  
float CurrentOutputByType(MyDefinitionId resourceTypeId)
```
继承于[MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase) 

----

[DefinedOutputByType](VRage.Game.Components.MyResourceSourceComponentBase.DefinedOutputByType)
```csharp
//定义的最大输出功率,单位 MW/h或者升/h.  
float DefinedOutputByType(MyDefinitionId resourceTypeId)
```
继承于 [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)

----

[MaxOutputByType](VRage.Game.Components.MyResourceSourceComponentBase.MaxOutputByType)
```csharp
//生产过程的最大输出功率,单位 MW/h或者升/h.  
float MaxOutputByType(MyDefinitionId resourceTypeId)
```
继承于 [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)

----

[ProductionEnabledByType](VRage.Game.Components.MyResourceSourceComponentBase.ProductionEnabledByType)
```csharp
//资源生产是否开启
bool ProductionEnabledByType(MyDefinitionId resourceTypeId)
```
继承于 [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)

