## The MDK / Visual Studio Specific Section
_如果您没有使用MDK，可以跳到下一节_

Ok, [您已经学习了C#的基本知识，并知道从哪里获得帮助](Quick-Introduction-to-Space-Engineers-Ingame-Scripts), 并且 [打开了全新的项目](Getting-Started)  (注释和使用removed以保持简洁):

```csharp
Namespace IngameScript
{
    partial class Program : MyGridProgram
    {
        public Program()
        {
        }

        public void Save()
        {
        }

        public void Main(string argument)
        {
        }
    }
}
```
首先需要注意的是名称空间 , `partial class Program : MyGridProgram` 代码片段不是可编程块脚本的一部分. 将此脚本项目部署到空间工程师时，实际上只使用程序类的代码内部. 原因是空间工程师需要严格控制脚本类_is_。脚本类_always_命名为`Program`，它是从`MyGridProgram`继承而来的_always。空间工程师会将这些部分添加到您的幕后脚本中。如果您只是在使用ingame编辑器、普通文本编辑器或类似的东西，则不需要添加这些内容. 具体 ["程序包装器和您为什么需要它"](The-Program-Wrapper-And-Why-You-Need-It).

## The General Section (不适用MDK)

这是您第一次打开新放置的可编程块时看到的内容（为简洁起见，删除了注释）：
```csharp
public Program()
{
}

public void Save()
{
}

public void Main(string argument)
{
}
```

#### 构造函数
```csharp
public Program() 
{

}
```
它用于脚本的一次性初始化，并在每次实例化脚本时运行一次。这意味着它在游戏加载后或重新编译脚本后运行一次。当您编辑脚本或按“重新编译”按钮时，会发生重新编译.
构造函数是可选的

#### 保存函数
```csharp
public void Save() 
{
}
```
无论何时保存游戏，或在重新编译脚本之前，都会调用Save方法。在这里，您可以存储在游戏会话之间需要保存的任何数据. 具体 [存储字符串](The-Storage-String)

此保存方法也是可选的。

#### 主函数
```csharp
public void Main(string argument) 
{
}
```
or simply
```csharp
public void Main() 
{
}
```
Main方法是脚本的主要入口点。在脚本的生命周期内，可能会多次调用它，具体取决于脚本的内容和设置方式。
显然，这种方法是必需的。
参数从游戏（取决于您的工具栏设置）传递到脚本，使单个脚本可以执行一系列不同的操作。您可以通过将可编程块拖动到按钮面板、传感器或计时器工具栏（或除套装外的任何其他设备工具栏）上并选择“运行”来设置此参数。您将看到一个输入框，您可以在其中输入想要传递给脚本的内容。它将逐字传递，请记住这一点。

#### 局限
可编程块脚本有三个不同的限制.

第一个是脚本本身的大小。脚本不能超过100000个字符.

第二个是所谓的“指令计数器”。在脚本中，每次运行最多只能有50000个代码连接。代码连接包括方法调用、开关、条件、循环等。像1+1这样的简单语句不会增加此计数. **注意，这只是一个工具**. 每次运行时，您应该尽量少执行代码。请记住，游戏每帧只有大约16毫秒的时间来执行_everything_，包括游戏逻辑、物理、渲染和您的世界中的_all_脚本。每纳秒计数!

第三个限制是您可以访问多少.NET框架。显然，完全访问该框架是危险的，因为这样人们可能会对他人的计算机做坏事。这就是为什么空间工程师使用白名单来限制您可以访问框架的哪些部分. 

如果使用 [MDK](Getting-Started), 它会告诉您是否试图引用不允许的类型或成员。现在可以通过创建新的MDK项目来尝试此操作:

```csharp
public void Main()
{
    System.Threading.Thread thread;
}
```

在MDK扩展的帮助下，VisualStudio将用一个错误标记它，告诉您`System.Threading.Thread` 被禁止.

