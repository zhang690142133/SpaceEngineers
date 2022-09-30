如何调试PB（可编程块）、mod甚至游戏异常。

**dnSpy**有一个**调试器**，它可以附加到游戏进程并捕获异常（即使它们已经被代码捕获），并暂停代码，以便您可以一步一步地检查代码，查看变量等。

**dnSpy**也是一个**反编译器**，您可以查看游戏的代码，甚至编译的PB/mod脚本，以了解游戏的编译器是如何改变它们的。具体请参见[查看编译代码]（#查看编译代码）。



## 获取dnspy

- 获取 https://github.com/0xd4d/dnSpy/releases (.NET Framework版本，而非NET核心版本!)

- 解压到任意位置 (e.g. `C:\Program Files\dnSpy\`).

- 运行64位版本 `dnSpy.exe`



## 常见错误

将dnSpy连接到游戏并监视异常的基本步骤。

1. 运行游戏和dnSpy。

2. dnSpy: `Debug -> Attach to process (Ctrl+Alt+P)` and double click SpaceEngineers.exe from that list.

   If you cannot see SE there and you have the NET framework dnSpy and ran the 64bit exe, then it might require running dnSpy as admin.

3. dnSpy: `Debug -> Windows -> Exception settings (Ctrl+Alt+E)` and pick what exceptions you want to catch.

   For example: search `null` and check `NullReferenceException`, the most common exception.

   If you're looking for the cause of "Script too complex", add `VRage.Compiler.ScriptOutOfRangeException` (with the green plus button).

4. In-game: Recompile the script (if it's a mod, reload the world to recompile).

   (This is only needed once after you attach. Details at [Seeing local variables when code is paused](advanced-dnspy-tips-and-tricks#seeing-local-variables-when-code-is-paused))

5. In-game: Run the script until it throws errors (exceptions).

6. Once the error occurs dnSpy will pause code execution, now proceed to [Navigating paused code](#navigating-paused-code).


## Navigating paused code

When dnSpy is attached to the game and you're monitoring for an exception or breakpoint (advanced topic: [Breakpoints](advanced-dnspy-tips-and-tricks#breakpoints)), then the game's code is paused and self-navigates to the exact line the exception or breakpoint occured.

Some things you can do here (in dnSpy):

- The top-center toolbar has some buttons with arrows and stuff: step-into, step-over or step-out to navigate the code flow.

- `Debug -> Windows -> Locals (Alt+4)` can show values from variables and fields from the current pause context.

  (Advanced topic: [Seeing local variables when code is paused](advanced-dnspy-tips-and-tricks#seeing-local-variables-when-code-is-paused))

- `Debug -> Windows -> Call Stack (Ctrl+Alt+C)` shows the exception stacktrace which you can double-click in to navigate to the mentioned code.

- Use the `Continue` button to resume the game (or exit the game if it's an unhandled exception, dnSpy only shows them to you, it doesn't prevent them).



## Looking at the compiled code

Since dnSpy is also a decompiler, you can look at the game code.

This doesn't require the game running.

1. `File -> Open` navigate to `<Steam>/steamapps/common/SpaceEngineers/Bin64`

2. Select all .dll and .exe files and click `Open`.

3. `Edit -> Search Assemblies (Ctrl+Shift+K)` and search away!

After that:

- What to search really depends on what you're looking for, if you want to know what properties an API interface has, then simply type that interface's name, maybe also set `Search for:` to `Type` to be more specific.

- `Right click anything -> Analyze` to see where it's used, implemented, raised, etc.

- For multiple projects (e.g. also having Medieval Engineers' libraries), see `File -> Open List`

***


_A big thank you goes to Digi for writing this tutorial._