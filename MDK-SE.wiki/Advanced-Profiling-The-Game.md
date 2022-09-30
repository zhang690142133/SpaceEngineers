Keen很好地让我们访问了他们的开发工具和分析器，通过一些下载和文件移动，你也可以使用这个版本的游戏。这将允许您测量脚本的性能，以确保它尽可能快地运行。

## Getting started
You'll need to set up a few things before you can start using the profiling version.

First things first, is you'll need to download the ModSDK for the game. Open your Steam library, hovering your pointer over the "Library" button to get the menu. Select "Tools", and find "Space Engineers - Mod SDK" from the list, and install it.

If it's not there you can force install it by pasting `steam://install/326880` in your browser address bar.

Once the ModSDK has finished downloading an installing, you need to open the directory where it's installed (You can get to this quickly by right-clicking the tool in your library, selecting `Properties`, `Local Files`, `Browse Local Files...`).

Next, you need to have `Bin64_Profile` in the game folder. You can simply copy it there but that also means you have to copy it every time game/SDK gets updated.

**NOTE**: Do not paste into the game's `Bin64` folder. Only copy the `Bin64_Profile` as is in the game's root folder.

Or, instead of copying, a better way is to make a directory junction:

1. If you already copied `Bin64_Profile` to your game, delete it.
2. Open notepad or something you can type in.
3. Paste: `mklink /J "<SEDir>\Bin64_Profile" "<SDKDir>\Bin64_Profile"`.
4. Replace `<SEDir>` with the path to the game.
5. Replace `<SDKDir>` with the path to the SDK.
6. Press <kbd>Win</kbd> + <kbd>R</kbd> and run `cmd`.
7. Copy the finished command from notepad to the commandline window (rightclick to paste) then <kbd>Enter</kbd>.


Finally, you can run the game via `<SE>/Bin64_Profile/SpaceEngineers.exe`.

### The short version
Here's how to install the profiling version of the game without all the extra fluff.
1. Install the Space Engineers - Mod SDK (as described above)
2. Copy `<SDK>/Bin64_Profile` to the game's folder _or_ create a directory junction (as described above).
3. Start the game from `<SE>/Bin64_Profile/SpaceEngineers.exe`



## In the game

Once in the game, the bottom right corner where the version is should also say `PROFILING` with red text, that means you're good to go.

When in a world (or even in the menu) press <kbd>Alt</kbd> + <kbd>NumPad .</kbd> to open the profiler view.

From here, you can use the various keybinds listed below to dig deeper into what's doing what in your game, see how long it's taking, and other _fun_ profiling things.

For profiling programmable blocks specifically, copy:

`UpdateInternal::Update > Session.Update > Before simulation > MySector > MyGameLogic.UpdateBeforeSimulation > PROGRAMMABLE_BLOCK`

then press <kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>NumPad \*</kbd>.


There are all kinds of debugging tools available in the profiler version of the game, accessible via <kbd>F12</kbd> (or <kbd>Alt</kbd> + <kbd>F12</kbd> to avoid taking a Steam screenshot) where you can mess with a lot of things, some of which can alter your game files so use with caution.

But this page is only here to detail how to use the profiler specifically.


<!-- ### Using the Profiler
Press <kbd>F12</kbd> in game (or <kbd>Alt</kbd>+<kbd>F12</kbd> to not make steam screenshot)
Select Performance tab
Check Profiler checkbox

Profiler has hidden controls explained on attached image.

To profile PB - You need to find your PB. It should be something like:
`Session.Update > Before Simulation > MySector > MyGameLogic.UpdateBeforeSimulation >  PROGRAMMABLE_BLOCK`

Run from terminal button will be somewhere in
`After update -> Handle input`-->



### Profiler Keybinds

The profiler has a lot of keybinds that aren't immediately obvious. They're listed here, grouped for convenience.

<table>
    <thead>
        <tr>
            <th>Key Combination</th>
            <th>Functionality</th>
        </tr>
    </thead>
    <tr>
        <td colspan="2"> <b>Profiler management</b> </td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>NumPad .</kbd></td>
        <td>Opens/closes the Profiler, doesn't reset the current profiler stack.</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>NumPad Enter</kbd></td>
        <td>Pause/unpause the profiler.</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>Insert</kbd></td>
        <td>Reset profiler data</td>
    </tr>
    <tr>
        <td colspan="2"></td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>NumPad /</kbd></td>
        <td>Decreases the level limit</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>NumPad *</kbd></td>
        <td>Increases the level limit</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>NumPad /</kbd></td>
        <td>Decreases the level limit by 1</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>NumPad *</kbd></td>
        <td>Increases the level limit by 1</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>E</kbd></td>
        <td>Toggle deep/shallow profile</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>E</kbd></td>
        <td>Toggle deep/shallow profile on connected DS</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>A</kbd></td>
        <td>Switch recording average times</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>A</kbd></td>
        <td>Switch recording average times on server</td>
    </tr>
    <tr>
        <td colspan="2"></td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>1</kbd>-<kbd>9</kbd></td>
        <td>Load profiler snapshot from file in `UserData/FullProfiler-X`</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>LCtrl</kbd> + <kbd>1</kbd>-<kbd>9</kbd></td>
        <td>Save profiler snapshot to file in `UserData/FullProfiler-X`</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>RCtrl</kbd> + <kbd>1</kbd>-<kbd>9</kbd></td>
        <td>Load snapshot from file and subtract it from current profiler data (diff)</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>LCtrl</kbd> + <kbd>1</kbd>-<kbd>9</kbd></td>
        <td>Save profiler snapshot on server</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>S</kbd></td>
        <td>Download current profiler data from server</td>
    </tr>
    <tr>
        <td colspan="2"><b>Profiler navigation</b></td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>NumPad 0</kbd></td>
        <td>Go back 1 block (Will open the profiler if it's closed, this is done for backwards compatibility with programmer muscle memory)</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>NumPad 1</kbd>-<kbd>NumPad 9</kbd></td>
        <td>Enter the next profiler block as usual</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>NumPad 1</kbd>-<kbd>NumPad 9</kbd></td>
        <td>Select block 10-19</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>Space</kbd> + <kbd>NumPad 1</kbd>-<kbd>NumPad 9</kbd></td>
        <td>Select block 20-29</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>Home</kbd></td>
        <td>Jump to root block</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>NumPad +</kbd></td>
        <td>Next thread</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>NumPad -</kbd></td>
        <td>Previous Thread</td>
    </tr>
    <tr>
        <td colspan="2" />
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>NumPad /</kbd></td>
        <td>Copy current profiler path to clipboard</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>NumPad *</kbd></td>
        <td>Try to navigate to the profiler path from the clipboard</td>
    </tr>
    <tr>
        <td colspan="2"><b>Profiler blocks optimization</b></td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>NumPad 0</kbd></td>
        <td>Toggles all child block optimization state</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>B</kbd> + <kbd>NumPad 1</kbd>-<kbd>NumPad 9</kbd></td>
        <td>Toggles block optimization state 1-9</td>
    </tr>
    <tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>B</kbd> + <kbd>NumPad 1</kbd>-<kbd>NumPad 9</kbd></td>
        <td>Toggles block optimization state 10-19</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>B</kbd> + <kbd>NumPad 1</kbd>-<kbd>NumPad 9</kbd></td>
        <td>Toggles block optimization state 20-29</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>B</kbd> + <kbd>NumPad Enter</kbd></td>
        <td>Toggles optimizations enabled/disabled</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>B</kbd> + <kbd>NumPad .</kbd></td>
        <td>Resets optimization on all blocks</td>
    </tr><tr>
        <td colspan="2"><b>Profiler display settings</b></td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Home</kbd></td>
        <td>Increase profiler scale</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>End</kbd></td>
        <td>Decrease profiler scale</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Insert</kbd></td>
        <td>Change profiler sorting order</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>NumPad +</kbd></td>
        <td>Increase local area (Used for calculating the average milliseconds)</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>NumPad -</kbd></td>
        <td>Decrease local area (Used for calculating the average milliseconds)</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Q</kbd></td>
        <td>Switch to alternative graph (Used for memory allocation profiling)</td>
    </tr><tr>
        <td colspan="2"><b>Profiler frame selection</b></td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>PageUp</kbd></td>
        <td>Go forward through frames</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>PageDown</kbd></td>
        <td>Go backwards through frames</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>PageUp</kbd></td>
        <td>Go forward through frames by 1 frame</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>PageDown</kbd></td>
        <td>Go backwards through frames by 1 frame</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>PageUp</kbd></td>
        <td>Fast forward through frames</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>PageDown</kbd></td>
        <td>Fast backwards through frames</td>
    </tr><tr>
        <td><kbd>Alt</kbd> + <kbd>Ctrl</kbd> + <kbd>End</kbd></td>
        <td>Disable selection mode</td>
    </tr>
</table>


### Generally interesting paths

`UpdateInternal::Update > Session.Update > Before simulation > MySector > MyEntities.UpdateBeforeSimulation`
`UpdateInternal::Update > Session.Update > After simulation > MySector > MyEntities.UpdateAfterSimulation`

You can make use of these paths by copying the text from here, opening the profiler ingame and pressing <kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>NumPad \*</kbd>.


***


_A big thank you goes to AndrielChaoti who was kind enough to compose this document, and MMaster for providing the original used as a source._