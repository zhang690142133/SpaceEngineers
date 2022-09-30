← [API索引](Api-Index) ← [命名空间索引](Namespace-Index) ← [ListExtensions](System.Collections.Generic.ListExtensions)

### 概要

```csharp
public static int BinaryIntervalSearch<T>(this IList<T> self, T value, IComparer<T> comparer = default)
```

### 返回

[int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6)

### 参数

* [IList&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netframework-4.6) self
* [T]() value
* [IComparer&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1?view=netframework-4.6) comparer
### 概要

```csharp
public static int BinaryIntervalSearch<T>(this IList<T> self, Func<T, bool> less)
```

### 返回

[int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6)

### 参数

* [IList&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netframework-4.6) self
* [Func&lt;T, bool&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) less
### 概要

```csharp
public static int BinaryIntervalSearch<T>(this IList<T> self, T value, Comparison<T> comparison)
```

### 返回

[int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6)

### 参数

* [IList&lt;T&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netframework-4.6) self
* [T]() value
* Comparison&lt;T&gt; <sub>prohibited</sub> comparison
