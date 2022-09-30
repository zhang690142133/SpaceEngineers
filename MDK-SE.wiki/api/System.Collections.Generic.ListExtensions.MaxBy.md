← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [ListExtensions](System.Collections.Generic.ListExtensions)

### 概要

```csharp
public static T MaxBy<T>(this IEnumerable<T> source, Func<T, float> selector)
```

### 返回

[T]()

### 参数

* [IEnumerable&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6) source
* [Func&lt;T, float&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) selector
### 概要

```csharp
public static TItem MaxBy<TItem, TKey>(this IEnumerable<TItem> source, Func<TItem, TKey> selector, IComparer<TKey> comparer = default)
```

### 返回

[TItem]()

### 参数

* [IEnumerable&lt;TItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6) source
* [Func&lt;TItem, TKey&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) selector
* [IComparer&lt;TKey&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1?view=netframework-4.6) comparer
