One of the more frequently asked questions for beginners, is how to get a hold of the programmable block or the grid _containing_ the programmable block that is running the current scripts. This is quite simple. The base class of the scripts, `MyGridProgram`, has a special property for this called `Me`.

```csharp
public void Main() {
    // Write the name of the running programmable block into its detail area
    Echo(Me.CustomName);

    // Write the name of the grid containing the programmable block into its detail area
    Echo(Me.CubeGrid.CustomName);
}
```