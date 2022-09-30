## Do:
* reuse your lists. You can initialize (`new`) your lists once and reuse them for the rest of the script's lifetime, you don't need to reallocate every time, this is very slow.

* design your own objects to follow the above guideline. Avoid allocation during general runtime.

* consider the fact that scripts take time to execute, leaving less time available for the rest of the game. The more you try to do, the more it will impact the game. If your script is just something you're gonna run in your single player game, you have much more time available than if you are going to use your script on a multiplayer server: Other players are bound to use scripts too. Advanced scripters might want to run their operations over multiple ticks using tricks like [yield-based coroutines](https://github.com/malware-dev/MDK-SE/wiki/Coroutines---Run-operations-over-multiple-ticks).

## Don't:
* fetch blocks every time a method is called. Prefetch and cache, because retrieving a block is a time-consuming operation. If you want the list to be kept up to date despite
users changing their ships, or damage happening to their builds, make sure this update only happens every few ticks (Update100 or more), and not constantly.

* use `static` fields or properties. Methods are fine, but static fields and properties are a potential source of memory leaks. Pass your instances around, don't be lazy.

* allocate new objects in often running code. Memory allocation is relatively slow, and it will give the [garbage collector](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/) a lot of objects to deal with, slowing down execution.

* use Terminal Properties or -Actions unless you have no other option. Calling members directly from their interfaces are orders of magnitude faster.
