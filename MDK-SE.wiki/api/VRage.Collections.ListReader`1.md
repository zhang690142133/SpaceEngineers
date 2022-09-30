← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### ListReader&lt;T&gt; Struct

```csharp
public struct ListReader<T>: IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
```

**命名空间:** [VRage.Collections](VRage.Collections)  
**Assembly:** VRage.Library.dll

**Implements:**  
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=netframework-4.6)  
* [IEnumerable&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)  
* [IReadOnlyCollection&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1?view=netframework-4.6)  
* [IReadOnlyList&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1?view=netframework-4.6)

#### Fields

[static ListReader&lt;T&gt; Empty](VRage.Collections.ListReader`1.Empty)

> 

#### Properties

[int Count { get; }](VRage.Collections.ListReader`1.Count)

> 

[T Item { get; }](VRage.Collections.ListReader`1.Item)

> 

#### Constructors

[ListReader(List&lt;T&gt; list)](VRage.Collections.ListReader`1..ctor)

> 

#### 方法

[Enumerator&lt;T&gt; GetEnumerator()](VRage.Collections.ListReader`1.GetEnumerator)

> 

[int IndexOf(T item)](VRage.Collections.ListReader`1.IndexOf)

> 

[T ItemAt(int index)](VRage.Collections.ListReader`1.ItemAt)

> 

