← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### ListExtensions Class

```csharp
public abstract sealed class ListExtensions
```

**命名空间:** [System.Collections.Generic](System.Collections.Generic)  
**Assembly:** VRage.Library.dll

#### 方法

[static void AddArray&lt;T&gt;(this List&lt;T&gt; list, T&#91&#93; itemsToAdd)](System.Collections.Generic.ListExtensions.AddArray)

> 

[static void AddArray&lt;T&gt;(this List&lt;T&gt; list, T&#91&#93; itemsToAdd, int itemCount)](System.Collections.Generic.ListExtensions.AddArray)

> 

[static void AddHashsetCasting&lt;T1, T2&gt;(this List&lt;T1&gt; list, HashSet&lt;T2&gt; hashset)](System.Collections.Generic.ListExtensions.AddHashsetCasting)

> 

[static void AddList&lt;T&gt;(this List&lt;T&gt; list, List&lt;T&gt; itemsToAdd)](System.Collections.Generic.ListExtensions.AddList)

> 

[static void AddOrInsert&lt;T&gt;(this List&lt;T&gt; list, T item, int index)](System.Collections.Generic.ListExtensions.AddOrInsert)

> 

[static void AssertEmpty&lt;T&gt;(this List&lt;T&gt; list)](System.Collections.Generic.ListExtensions.AssertEmpty)

> 

[static T AtMod&lt;T&gt;(this List&lt;T&gt; list, int index)](System.Collections.Generic.ListExtensions.AtMod)

> 

[static T AtMod&lt;T&gt;(this ListReader&lt;T&gt; list, int index)](System.Collections.Generic.ListExtensions.AtMod)

> 

[static int BinaryIntervalSearch&lt;T&gt;(this IList&lt;T&gt; self, T value, IComparer&lt;T&gt; comparer = default)](System.Collections.Generic.ListExtensions.BinaryIntervalSearch)

> 

[static int BinaryIntervalSearch&lt;T&gt;(this IList&lt;T&gt; self, Func&lt;T, bool&gt; less)](System.Collections.Generic.ListExtensions.BinaryIntervalSearch)

> 

[static int BinaryIntervalSearch&lt;T&gt;(this IList&lt;T&gt; self, T value, Comparison&lt;T&gt; comparison)](System.Collections.Generic.ListExtensions.BinaryIntervalSearch)

> 

[static void ClearAndTrim&lt;T&gt;(this List&lt;T&gt; list, int maxElements)](System.Collections.Generic.ListExtensions.ClearAndTrim)

> 

[static void EnsureCapacity&lt;T&gt;(this List&lt;T&gt; list, int capacity)](System.Collections.Generic.ListExtensions.EnsureCapacity)

> 

[static ClearToken&lt;T&gt; GetClearToken&lt;T&gt;(this List&lt;T&gt; list)](System.Collections.Generic.ListExtensions.GetClearToken)

> 

[static void InsertInOrder&lt;T&gt;(this List&lt;T&gt; self, T value, IComparer&lt;T&gt; comparer)](System.Collections.Generic.ListExtensions.InsertInOrder)

> 

[static void InsertInOrder&lt;T&gt;(this List&lt;T&gt; self, T value)](System.Collections.Generic.ListExtensions.InsertInOrder)

> 

[static bool IsSorted&lt;T&gt;(this List&lt;T&gt; self, IComparer&lt;T&gt; comparer)](System.Collections.Generic.ListExtensions.IsSorted)

> 

[static bool IsValidIndex&lt;T&gt;(this List&lt;T&gt; list, int index)](System.Collections.Generic.ListExtensions.IsValidIndex)

> 

[static T MaxBy&lt;T&gt;(this IEnumerable&lt;T&gt; source, Func&lt;T, float&gt; selector)](System.Collections.Generic.ListExtensions.MaxBy)

> 

[static TItem MaxBy&lt;TItem, TKey&gt;(this IEnumerable&lt;TItem&gt; source, Func&lt;TItem, TKey&gt; selector, IComparer&lt;TKey&gt; comparer = default)](System.Collections.Generic.ListExtensions.MaxBy)

> 

[static T MinBy&lt;T&gt;(this IEnumerable&lt;T&gt; source, Func&lt;T, float&gt; selector)](System.Collections.Generic.ListExtensions.MinBy)

> 

[static void Move&lt;T&gt;(this List&lt;T&gt; list, int originalIndex, int targetIndex)](System.Collections.Generic.ListExtensions.Move)

> 

[static TValue Pop&lt;TValue&gt;(this List&lt;TValue&gt; self)](System.Collections.Generic.ListExtensions.Pop)

> 

[static void RemoveAtFast&lt;T&gt;(this List&lt;T&gt; list, int index)](System.Collections.Generic.ListExtensions.RemoveAtFast)

> 

[static void RemoveAtFast&lt;T&gt;(this IList&lt;T&gt; list, int index)](System.Collections.Generic.ListExtensions.RemoveAtFast)

> 

[static void RemoveIndices&lt;T&gt;(this List&lt;T&gt; list, List&lt;int&gt; indices)](System.Collections.Generic.ListExtensions.RemoveIndices)

> 

[static void SortNoAlloc&lt;T&gt;(this List&lt;T&gt; list, Comparison&lt;T&gt; comparator)](System.Collections.Generic.ListExtensions.SortNoAlloc)

> 

[static void Swap&lt;T&gt;(this List&lt;T&gt; list, int a, int b)](System.Collections.Generic.ListExtensions.Swap)

> 

[static O&#91&#93; ToArray&lt;I, O&gt;(this IList&lt;I&gt; collection, Func&lt;I, O&gt; selector)](System.Collections.Generic.ListExtensions.ToArray)

> 

[static T&#91&#93; GetInternalArray&lt;T&gt;(this List&lt;T&gt; list)](System.Collections.Generic.ListExtensions.GetInternalArray)

> _**Obsolete:** Due to changes required for XBOX this method is obsolete. Do not use it, as now it simply does list.ToArray_

