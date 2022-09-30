Again let's look at the program wrapper used in MDK projects.

```csharp
Namespace IngameScript
{
    partial class Program : MyGridProgram
    {
        // Your Script Goes Here
    }
}
```
This wrapper class has two purposes: Firstly to provide access to the game specific constructs like [GridTerminalSystem](https://github.com/malware-dev/MDK-SE/wiki/The-Grid-Terminal-System) and [Echo](https://github.com/malware-dev/MDK-SE/wiki/Debugging-Your-Scripts). Secondly it's here to simulate the environment your script executes in when the programmable block is running your script.

_All_ your code, even classes and other types, should be wrapped this way to make sure that Visual Studio behaves the same way the Programmable Block will. If you don't, you risk getting compiler errors in Visual Studio that will not happen in the programmable block, and vice versa. The only exception to this wrapping rule are the officially sanctioned "exploit" that are [extension classes](https://github.com/malware-dev/MDK-SE/wiki/Utility-Class-or-Extension-Class#extension-classes).