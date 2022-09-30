← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### IMyTextSurface Interface

```csharp
public interface IMyTextSurface
```

Describes one of block LCDs where you can write text or draw things (PB scripting interface)

**命名空间:** [Sandbox.ModAPI.Ingame](Sandbox.ModAPI.Ingame)  
**Assembly:** Sandbox.Common.dll

**Inheritors:**  
* [IMyTextPanel](Sandbox.ModAPI.Ingame.IMyTextPanel)

#### Properties

[TextAlignment Alignment { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.Alignment)

> How should the text be aligned

[byte BackgroundAlpha { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.BackgroundAlpha)

> Value for offscreen texture alpha channel - for PBR material it is metalness (should be 0) - for transparent texture it is opacity

[Color BackgroundColor { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.BackgroundColor)

> Gets or sets background color

[float ChangeInterval { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.ChangeInterval)

> Gets or sets the change interval for selected textures

[ContentType ContentType { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.ContentType)

> Type of content to be displayed on the screen.

[string CurrentlyShownImage { get; }](Sandbox.ModAPI.Ingame.IMyTextSurface.CurrentlyShownImage)

> Gets image that is currently shown on the screen. Returns NULL if there are no images selected OR the screen is in text mode.

[string DisplayName { get; }](Sandbox.ModAPI.Ingame.IMyTextSurface.DisplayName)

> Get localized name of this surface.

[string Font { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.Font)

> Gets or sets the font

[Color FontColor { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.FontColor)

> Gets or sets font color

[float FontSize { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.FontSize)

> Gets or sets font size

[string Name { get; }](Sandbox.ModAPI.Ingame.IMyTextSurface.Name)

> Gets identifier name of this surface.

[bool PreserveAspectRatio { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.PreserveAspectRatio)

> Gets or sets preserve aspect ratio of images.

[string Script { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.Script)

> Currently running script

[Color ScriptBackgroundColor { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.ScriptBackgroundColor)

> Gets or sets background color used for scripts.

[Color ScriptForegroundColor { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.ScriptForegroundColor)

> Gets or sets foreground color used for scripts.

[Vector2 SurfaceSize { get; }](Sandbox.ModAPI.Ingame.IMyTextSurface.SurfaceSize)

> Gets size of the drawing surface.

[float TextPadding { get; set; }](Sandbox.ModAPI.Ingame.IMyTextSurface.TextPadding)

> Gets or sets text padding from all sides of the panel.

[Vector2 TextureSize { get; }](Sandbox.ModAPI.Ingame.IMyTextSurface.TextureSize)

> Gets size of the texture the drawing surface is rendered to.

#### 方法

[void AddImagesToSelection(List&lt;string&gt; ids, bool checkExistence = default)](Sandbox.ModAPI.Ingame.IMyTextSurface.AddImagesToSelection)

> Adds image to list of shown images. You can get image ids by [GetSelectedImages(List<string>)](Sandbox.ModAPI.Ingame.IMyTextSurface.GetSelectedImages) 

[void AddImageToSelection(string id, bool checkExistence = default)](Sandbox.ModAPI.Ingame.IMyTextSurface.AddImageToSelection)

> Adds image to list of shown images. You can get image ids by [GetSelectedImages(List<string>)](Sandbox.ModAPI.Ingame.IMyTextSurface.GetSelectedImages) 

[void ClearImagesFromSelection()](Sandbox.ModAPI.Ingame.IMyTextSurface.ClearImagesFromSelection)

> Removes images from shown images.

[MySpriteDrawFrame DrawFrame()](Sandbox.ModAPI.Ingame.IMyTextSurface.DrawFrame)

> Creates a new draw frame where you can add sprites to be rendered.

[void GetFonts(List&lt;string&gt; fonts)](Sandbox.ModAPI.Ingame.IMyTextSurface.GetFonts)

> Gets a list of available fonts

[void GetScripts(List&lt;string&gt; scripts)](Sandbox.ModAPI.Ingame.IMyTextSurface.GetScripts)

> Gets a list of available scripts

[void GetSelectedImages(List&lt;string&gt; output)](Sandbox.ModAPI.Ingame.IMyTextSurface.GetSelectedImages)

> Outputs the selected image ids to the specified list. NOTE: List is not cleared internally.

[void GetSprites(List&lt;string&gt; sprites)](Sandbox.ModAPI.Ingame.IMyTextSurface.GetSprites)

> Gets a list of available sprites

[string GetText()](Sandbox.ModAPI.Ingame.IMyTextSurface.GetText)

> Gets current text that is written on surface. Allocates memory (StringBuilder.ToString())! This method doesn't allocate memory [ReadText(StringBuilder, bool = default)](Sandbox.ModAPI.Ingame.IMyTextSurface.ReadText) 

[Vector2 MeasureStringInPixels(StringBuilder text, string font, float scale)](Sandbox.ModAPI.Ingame.IMyTextSurface.MeasureStringInPixels)

> Calculates how many pixels a string of a given font and scale will take up.

[void ReadText(StringBuilder buffer, bool append = default)](Sandbox.ModAPI.Ingame.IMyTextSurface.ReadText)

> Gets current text that is written on surface.

[void RemoveImageFromSelection(string id, bool removeDuplicates = default)](Sandbox.ModAPI.Ingame.IMyTextSurface.RemoveImageFromSelection)

> Removes image from shown images.

[void RemoveImagesFromSelection(List&lt;string&gt; ids, bool removeDuplicates = default)](Sandbox.ModAPI.Ingame.IMyTextSurface.RemoveImagesFromSelection)

> Removes images from shown images.

[bool WriteText(string value, bool append = default)](Sandbox.ModAPI.Ingame.IMyTextSurface.WriteText)

> Writes text to surface. If somebody opened LCD text in popup dialog, text can no longer be added to the surface. Resulting text must is capped with 100000 symbols

[bool WriteText(StringBuilder value, bool append = default)](Sandbox.ModAPI.Ingame.IMyTextSurface.WriteText)

> Writes text to surface. If somebody opened LCD text in popup dialog, text can no longer be added to the surface. Resulting text must is capped with 100000 symbols

