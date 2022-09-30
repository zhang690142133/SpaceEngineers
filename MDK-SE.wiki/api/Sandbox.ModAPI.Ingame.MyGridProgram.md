← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyGridProgram Class

```csharp
public abstract class MyGridProgram: IMyGridProgram
```

All programmable block scripts derive from this class, meaning that all properties in this class are directly available for use in your scripts. If you use Visual Studio or other external editors to write your scripts, you can derive directly from this class and have a compatible script template.

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

**Implements:**  
* IMyGridProgram <sub>prohibited</sub>

#### Example

```csharp  
public void Main()  
{  
    // Print out the time elapsed since the currently running programmable block was run  
    // the last time.  
    Echo(Me.CustomName + " was last run " + Runtime.TimeSinceLastRun.TotalSeconds + " seconds ago.");  
}  
  
```

#### Properties

[Action&lt;string&gt; Echo { get; protected set; }](Sandbox.ModAPI.Ingame.MyGridProgram.Echo)

> Prints out text onto the currently running programmable block's detail info area.

[IMyGridTerminalSystem GridTerminalSystem { get; protected set; }](Sandbox.ModAPI.Ingame.MyGridProgram.GridTerminalSystem)

> Provides access to the grid terminal system as viewed from this programmable block.

[IMyIntergridCommunicationSystem IGC { get; }](Sandbox.ModAPI.Ingame.MyGridProgram.IGC)

> Gets IGC instance

[IMyProgrammableBlock Me { get; protected set; }](Sandbox.ModAPI.Ingame.MyGridProgram.Me)

> Gets a reference to the currently running programmable block.

[IMyGridProgramRuntimeInfo Runtime { get; protected set; }](Sandbox.ModAPI.Ingame.MyGridProgram.Runtime)

> Gets runtime information for the running grid program.

[string Storage { get; protected set; }](Sandbox.ModAPI.Ingame.MyGridProgram.Storage)

> Allows you to store data between game sessions.

