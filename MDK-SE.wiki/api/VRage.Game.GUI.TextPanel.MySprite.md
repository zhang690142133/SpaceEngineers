← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MySprite Struct

```csharp
public struct MySprite: IEquatable<MySprite>
```

**命名空间:** [VRage.Game.GUI.TextPanel](VRage.Game.GUI.TextPanel)  
**Assembly:** VRage.Game.dll

**Implements:**  
* [IEquatable&lt;MySprite&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

#### Fields

[TextAlignment Alignment](VRage.Game.GUI.TextPanel.MySprite.Alignment)

> Alignment for the text and sprites.

[Color? Color](VRage.Game.GUI.TextPanel.MySprite.Color)

> Color mask to be used when rendering this layer. If not set, white will be used

[string Data](VRage.Game.GUI.TextPanel.MySprite.Data)

> Data to be rendered, depending on what the layer type is. This can be text or a texture path

[string FontId](VRage.Game.GUI.TextPanel.MySprite.FontId)

> In case we are rendering text, what font to use.

[Vector2? Position](VRage.Game.GUI.TextPanel.MySprite.Position)

> Render position for this layer. If not set, it will be placed in the center

[float RotationOrScale](VRage.Game.GUI.TextPanel.MySprite.RotationOrScale)

> Rotation of sprite in radians. Used as scale for text.

[Vector2? Size](VRage.Game.GUI.TextPanel.MySprite.Size)

> Render size for this layer. If not set, it will be sized to take up the whole texture

[SpriteType Type](VRage.Game.GUI.TextPanel.MySprite.Type)

> Type of the render layer

#### Constructors

[MySprite(SpriteType type = SpriteType.TEXTURE, string data = null, Vector2? position = default, Vector2? size = default, Color? color = default, string fontId = null, TextAlignment alignment = TextAlignment.CENTER, float rotation = 0)](VRage.Game.GUI.TextPanel.MySprite..ctor)

> 

#### 方法

[static MySprite CreateClearClipRect()](VRage.Game.GUI.TextPanel.MySprite.CreateClearClipRect)

> 

[static MySprite CreateClipRect(Rectangle rect)](VRage.Game.GUI.TextPanel.MySprite.CreateClipRect)

> 

[static MySprite CreateSprite(string sprite, Vector2 position, Vector2 size)](VRage.Game.GUI.TextPanel.MySprite.CreateSprite)

> 

[static MySprite CreateText(string text, string fontId, Color color, float scale = 1, TextAlignment alignment = TextAlignment.CENTER)](VRage.Game.GUI.TextPanel.MySprite.CreateText)

> 

[bool Equals(MySprite other)](VRage.Game.GUI.TextPanel.MySprite.Equals)

> 

[bool Equals(object obj)](VRage.Game.GUI.TextPanel.MySprite.Equals)

> 

[int GetHashCode()](VRage.Game.GUI.TextPanel.MySprite.GetHashCode)

> 

