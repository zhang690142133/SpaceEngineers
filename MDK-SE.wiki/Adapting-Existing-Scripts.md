当你将找到的脚本复制到项目中的.cs文件中,出现一大堆编译错误时
这是因为SE脚本需要外部包装器才能工作:
具体参看 [脚本的剖析](The-Anatomy-of-a-Script). 

```csharp
// using...

Namespace IngameScript
{
    partial class Program : MyGridProgram
    {
      // 将脚本粘贴到此处.
    }
}
```

