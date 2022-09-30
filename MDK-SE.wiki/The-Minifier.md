The purpose of the minifier is to rename and compact your code in a way that allows you to fit _more_ code into the limited space allowed by the game. Rest assured that this is perfectly fine as the reason for the script limit is because of network transfer, not code performance or anything like that. _What_ you write is more important than _how much_ you write.

The minifier is split into two separate functions. The first and simplest is a way to remove types you are not using in your code. Simply enable the "Type Trimming" checkbox in the new MDK script wizard or in the script options dialog.

The second function is the fullblown minifier that removes all formatting, removes unnecessary whitespace and renames all symbols it can to the smallest symbol name it can use.

### Unminified Section
Some times there's code you don't want to be minified, for whatever reason. The unminified section system also works by code regions. Simply add the code or comments you wish to preserve within such a region to have the minifier skip over it. Be aware though, that it won't necessarily be completely untouched. Some minor adjustments might be made, but naming will be untouched, and formatting will _most probably_ be.
```cs
#region mdk preserve
// Stuff I don't want the minifier to touch
#endregion
```

### But the minifier is slow...
One big issue with the minifier is that it's rather slow. So you will want to wait with minifying until you have a release ready script. Of course, the problem with this is that the game won't fit your script so you can't test it without minifying your script. Rexxar and Equinox came up with a solution to this: A plugin you can use on your game locally (won't work when you're on a server) to override the character limit of the programmable block. This way you can write and test your script _without_ minifying, until you're ready.

To use the plugin, [download it from here](https://github.com/malware-dev/MDK-SE/blob/master/binaries/PBUnlimiter.zip?raw=true), and extract the DLL to a convenient location.

Edit your Steam launch option by right-clicking on the game in Steam, select `properties`, the `General` tab, and click the button named `Set launch options`. Add `-plugin FullPathToTheDLLHere`. That's all you need to do; your limit is now gone.

Again; since scripts run on the server, this will only work for local games.

**Note:** The DLL in this zip will likely be blocked by your OS. This will cause the game to crash as it will refuse to load the assembly. You will need to right-click the DLL, select properties, and unblock it.
