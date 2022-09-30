← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyTexts Class

```csharp
public abstract sealed class MyTexts
```

**命名空间:** [VRage](VRage)  
**Assembly:** VRage.dll

#### Fields

[static MyStringId GAMEPAD_VARIANT_ID](VRage.MyTexts.GAMEPAD_VARIANT_ID)

> 

#### Properties

[static MyStringId GlobalVariantSelector { get; }](VRage.MyTexts.GlobalVariantSelector)

> Global selector for translation variants.

[static DictionaryReader&lt;MyLanguagesEnum, MyLanguageDescription&gt; Languages { get; }](VRage.MyTexts.Languages)

> 

#### 方法

[static StringBuilder AppendFormat(this StringBuilder stringBuilder, MyStringId textEnum, object arg0)](VRage.MyTexts.AppendFormat)

> 

[static StringBuilder AppendFormat(this StringBuilder stringBuilder, MyStringId textEnum, Object&#91&#93; arg)](VRage.MyTexts.AppendFormat)

> 

[static StringBuilder AppendFormat(this StringBuilder stringBuilder, MyStringId textEnum, MyStringId arg0)](VRage.MyTexts.AppendFormat)

> 

[static void Clear()](VRage.MyTexts.Clear)

> 

[static bool Exists(MyStringId id)](VRage.MyTexts.Exists)

> 

[static StringBuilder Get(MyStringId id)](VRage.MyTexts.Get)

> 

[static MyLanguagesEnum GetBestSuitableLanguage(string culture)](VRage.MyTexts.GetBestSuitableLanguage)

> 

[static string GetString(MyStringId id)](VRage.MyTexts.GetString)

> 

[static string GetString(string keyString)](VRage.MyTexts.GetString)

> 

[static string GetSystemLanguage()](VRage.MyTexts.GetSystemLanguage)

> 

[static bool IsTagged(string text, int position, string tag)](VRage.MyTexts.IsTagged)

> 

[static void LoadSupportedLanguages(string rootDirectory, HashSet&lt;MyLanguagesEnum&gt; outSupportedLanguages)](VRage.MyTexts.LoadSupportedLanguages)

> 

[static void LoadTexts(string rootDirectory, string cultureName = null, string subcultureName = null)](VRage.MyTexts.LoadTexts)

> 

[static bool MatchesReplaceFormat(string str)](VRage.MyTexts.MatchesReplaceFormat)

> 

[static void RegisterEvaluator(string prefix, ITextEvaluator eval)](VRage.MyTexts.RegisterEvaluator)

> 

[static void SetGlobalVariantSelector(MyStringId variantName)](VRage.MyTexts.SetGlobalVariantSelector)

> Set the global variant to be selected for each translation.

[static string SubstituteTexts(string text, string context = null)](VRage.MyTexts.SubstituteTexts)

> 

[static StringBuilder SubstituteTexts(StringBuilder text)](VRage.MyTexts.SubstituteTexts)

> 

[static string TrySubstitute(string input)](VRage.MyTexts.TrySubstitute)

> 

