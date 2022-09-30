← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [DictionaryExtensions](System.Collections.Generic.DictionaryExtensions)

### 概要

```csharp
public static TValue GetOrAdd<TKey, TValue, TContext>(this ConcurrentDictionary<TKey, TValue> dictionary, TKey key, TContext context, Func<TContext, TKey, TValue> activator)
```

### 返回

[TValue]()

### 参数

* ConcurrentDictionary&lt;TKey, TValue&gt; <sub>prohibited</sub> dictionary
* [TKey]() key
* [TContext]() context
* [Func&lt;TContext, TKey, TValue&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3?view=netframework-4.6) activator
