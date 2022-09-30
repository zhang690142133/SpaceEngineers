Some time ago we finally got a way to make more advanced and pretty screens using the programmable block. These **sprites** are really designed for use with the new LCD Script system (the script menu you get for each LCD panel) but we were also given the ability to draw these sprites using the programmable block.

As always, you can get further help by asking in the #programming-in-game channel of [Keen's discord](https://discord.gg/keenswh).

## Table Of Contents
* [Configuring Text Surfaces](#configuring-text-surfaces)
* [Fetching Text Surfaces And Preparing The Script](#fetching-text-surfaces-and-preparing-the-script)
* [The Viewport](#the-viewport)
* [Drawing A Frame](#drawing-a-frame)
* [Drawing Sprites](#drawing-sprites)
    * [Text Sprites](#text-sprites)
    * [Texture Sprites](#texture-sprites)
    * [Clipping Sprites](#clipping-sprites)
* [The Color Settings](#the-color-settings)
* [Configuring a text surface to display sprites through code](#configuring-a-text-surface-to-display-sprites-through-code)
* [Final Code Listing](#final-code-listing)

I have provided a [listing of the vanilla sprites here](Sprite-Listing).

### Configuring Text Surfaces

Every block with modifiable text surfaces will show a list of text surfaces in the control panel.

![Text Surface List](images/textsurface-list.jpg)

For the programmable block, there's two. The number and names will vary across different blocks.

To manually set up a text surface for sprite drawing, select the text surface you wish to draw on, then select `Script` in the Content drop box below the surface list. A new set of controls will show up below the Content drop box.

![Text Surface Content](images/textsurface-content.jpg)

The scripts listed in this list are _not_ programmable block scripts. They are special built-in (or modded) scripts that we cannot directly modify in-game. So, for our purposes, we want to make sure that we select `None`.
This will allow the programmable block to control the output of this text panel.

The sliders below control the background and foreground colors of the sprites. We will talk more about those later.

### Fetching Text Surfaces And Preparing The Script

In order to draw on a text surface, we need to retrieve it first. For the sake of this example, we will simply be working on the large text panel of the running programmable block, but the principle applies for all
blocks with scriptable text panels.

Every block with scriptable text panels implements the interface [`IMyTextSurfaceProvider`](Sandbox.ModAPI.Ingame.IMyTextSurfaceProvider). This interface contains the members we need to retrieve the text surface we 
want to draw on. We want to use the `GetSurface` method. It takes a single parameter, the index of the text surface to retrieve. These text surfaces are ordered the same way as we see in the list above, so in our
example we will want to retrieve the _first_ text panel, since that is the Large Display. Most indices in C# are 0-based, so we will want to retrieve surface 0.

The sprite system is designed to be continually updated. If you don't periodically update your display in sprite mode, it will fall back to the default image for that particular text surface. For this reason we need to set up [continuous execution of our script](Continuous-Running-No-Timers-Needed). For the sake of our simple demo script, we'll just update every 100 ticks. Update rates are maxed out at every 10 ticks for sprites, so updating _every_ tick is a waste of processing power.

```csharp
IMyTextSurface _drawingSurface;

// Script constructor
public Program()
{
    // Me is the programmable block which is running this script.
    // Retrieve the Large Display, which is the first surface
    _drawingSurface = Me.GetSurface(0);

    // Set the continuous update frequency of this script
    Runtime.UpdateFrequency = UpdateFrequency.Update100;
}
```
### The Viewport

There is a difference between the actual texture we draw on, and the area that is actually visible on the block. This visible Surface size is given to us through the `SurfaceSize` property, and the size of the texture we're drawing on is available through the `TextureSize` property.

The majority of the text surfaces _center_ this surface on its texture, like this:  
![Text Surface Viewport](images/textsurface-viewport.png)

This means that in order to place our sprites where we _expect_ them to be within what we actually see, we'll need to calculate this offset. I choose to do this by creating a full `RectangleF` which describes both the offset and size of the area we actually see in the game.

Let's update our constructor with this new code.

```csharp
IMyTextSurface _drawingSurface;
RectangleF _viewport;

// Script constructor
public Program()
{
    // Me is the programmable block which is running this script.
    // Retrieve the Large Display, which is the first surface
    _drawingSurface = Me.GetSurface(0);

    // Set the continuous update frequency of this script
    Runtime.UpdateFrequency = UpdateFrequency.Update100;

    // Calculate the viewport offset by centering the surface size onto the texture size
    _viewport = new RectangleF(
        (_drawingSurface.TextureSize - _drawingSurface.SurfaceSize) / 2f,
        _drawingSurface.SurfaceSize
    );
}
```
### Drawing A Frame

The drawing API is for all intents and purposes quite low level. You tell the surface that you wish to start a new frame, then you create and add a bunch of sprites, then you tell the surface that you're done. 

```csharp
// Main Entry Point
public void Main(string argument, UpdateType updateType)
{
    // Begin a new frame
    var frame = _drawingSurface.DrawFrame();

    // All sprites must be added to the frame here
    DrawSprites(ref frame);

    // We are done with the frame, send all the sprites to the text panel
    frame.Dispose();
}
```

Note that every `DrawFrame` will overwrite the previous. You cannot have multiple `DrawFrame` calls within a single Main call.

### Drawing Sprites

Sprites are drawn by adding instructions to the MySpriteDrawFrame on how they should be drawn. This is done through the [`MySprite`](VRage.Game.GUI.TextPanel.MySprite) structure. It consists of the following fields:

|Member|Description|
|---|---|
|[Type](VRage.Game.GUI.TextPanel.MySprite.Type)|Type of sprite; either SpriteType.TEXT or SpriteType.TEXTURE|
|[Position](VRage.Game.GUI.TextPanel.MySprite.Position)|Render position for this sprite. If not set, it will be placed in the center.|
|[Size](VRage.Game.GUI.TextPanel.MySprite.Size)|Render size for this sprite. If not set, it will be sized to take up the whole texture. This field has no purpose for SpriteType.TEXT sprites.|
|[Color](VRage.Game.GUI.TextPanel.MySprite.Color)|Color mask to be used when rendering this sprite. If not set, white will be used.|
|[Data](VRage.Game.GUI.TextPanel.MySprite.Data)|Data to be rendered, depending on what the sprite type is. This can be text or a texture name.|
|[FontId](VRage.Game.GUI.TextPanel.MySprite.FontId)|In case we are rendering text, what font to use.|
|[Alignment](VRage.Game.GUI.TextPanel.MySprite.Alignment)|Alignment for the text and sprites.|
|[RotationOrScale](VRage.Game.GUI.TextPanel.MySprite.RotationOrScale)|Rotation of sprite in radians for SpriteType.TEXTURE, scale for SpriteType.TEXT.|

#### Text Sprites

Our first example will be drawing two lines of text in two different colors. To do this we will create and add two text sprites.

We will be using the `White` font. This is the font I recommend to use for most purposes as it is the cleanest. See [`GetFonts`](Sandbox.ModAPI.Ingame.IMyTextSurface.GetFonts) for how to retrieve a list of all available fonts.

```csharp
// Drawing Sprites
public void DrawSprites(ref MySpriteDrawFrame frame)
{
    // Set up the initial position - and remember to add our viewport offset
    var position = new Vector2(256, 20) + _viewport.Position;
    
    // Create our first line
    var sprite = new MySprite()
    {
        Type = SpriteType.TEXT,
        Data = "Line 1",
        Position = position,
        RotationOrScale = 0.8f /* 80 % of the font's default size */,
        Color = Color.Red,
        Alignment = TextAlignment.CENTER /* Center the text on the position */,
        FontId = "White"
    };
    // Add the sprite to the frame
    frame.Add(sprite);
    
    // Move our position 20 pixels down in the viewport for the next line
    position += new Vector2(0, 20);

    // Create our second line, we'll just reuse our previous sprite variable - this is not necessary, just
    // a simplification in this case.
    sprite = new MySprite()
    {
        Type = SpriteType.TEXT,
        Data = "Line 2",
        Position = position,
        RotationOrScale = 0.8f,
        Color = Color.Blue,
        Alignment = TextAlignment.CENTER,
        FontId = "White"
    };
    // Add the sprite to the frame
    frame.Add(sprite);
}
```

#### Texture Sprites

Let's add a texture sprite to our surface. Let's add the grid Keen is so fond of. We do this by creating a texture sprite at the center of the surface, and scaling its size to the desired width and height.

See [`GetSprites`](Sandbox.ModAPI.Ingame.IMyTextSurface.GetSprites) for how to retrieve a list of all available sprites.

```csharp
// Drawing Sprites
public void DrawSprites(ref MySpriteDrawFrame frame)
{
    // Create background sprite
    var sprite = new MySprite()
    {
        Type = SpriteType.TEXTURE,
        Data = "Grid",
        Position = _viewport.Center,
        Size = _viewport.Size,
        Color = Color.White.Alpha(0.66f),
        Alignment = TextAlignment.CENTER
    };
    // Add the sprite to the frame
    frame.Add(sprite);

    // Set up the initial position - and remember to add our viewport offset
    var position = new Vector2(256, 20) + _viewport.Position;
    
    // Create our first line
    sprite = new MySprite()
    {
        Type = SpriteType.TEXT,
        Data = "Line 1",
        Position = position,
        RotationOrScale = 0.8f /* 80 % of the font's default size */,
        Color = Color.Red,
        Alignment = TextAlignment.CENTER /* Center the text on the position */,
        FontId = "White"
    };
    // Add the sprite to the frame
    frame.Add(sprite);
    
    // Move our position 20 pixels down in the viewport for the next line
    position += new Vector2(0, 20);

    // Create our second line, we'll just reuse our previous sprite variable - this is not necessary, just
    // a simplification in this case.
    sprite = new MySprite()
    {
        Type = SpriteType.TEXT,
        Data = "Line 2",
        Position = position,
        RotationOrScale = 0.8f,
        Color = Color.Blue,
        Alignment = TextAlignment.CENTER,
        FontId = "White"
    };
    // Add the sprite to the frame
    frame.Add(sprite);
}
```
#### Clipping Sprites

The final sprite type is a _clipping sprite._ This is a special type of sprite that allows you to create a rectangular area where any pixels _outside_ of it will be rejected by the renderer. Take the following code segment:

```csharp
// Here we add our clipping sprite. This is a simple rectangle. Nothing will be drawn outside it.
// We create a rectangle that is covering the first half of the next line, cutting it off in the 
// middle. 
sprite = MySprite.CreateClipRect(new Rectangle(0, (int)position.Y - 16, (int)position.X, (int)position.Y + 16));
// Add the sprite to the frame
frame.Add(sprite);
```
The `position` variable in this example specifies the _center point_ of the sprite we want to draw later, so we're creating a rectangle that will cover a little bit above and a little bit below, and from the left side of the screen and using the position X coordinate as a width, making it cover only _half_ the Line 2. The rest will be cut away.

If we want to remove the clipping rectangle, we can add a Clear sprite.

```csharp
sprite = MySprite.CreateClearClipRect();
```

This will reset the viewport to its default. We will not be using this particular code in our example, because we don't need to. 

Add the example above to the DrawSprites method like this. See right above the creation of the final line for the clipping code.
```csharp
// Drawing Sprites
public void DrawSprites(ref MySpriteDrawFrame frame)
{
    // Create background sprite
    var sprite = new MySprite
    {
        Type = SpriteType.TEXTURE,
        Data = "Grid",
        Position = _viewport.Center,
        Size = _viewport.Size,
        Color = Color.White.Alpha(0.66f),
        Alignment = TextAlignment.CENTER
    };
    // Add the sprite to the frame
    frame.Add(sprite);

    // Set up the initial position - and remember to add our viewport offset
    var position = new Vector2(256, 20) + _viewport.Position;

    // Create our first line
    sprite = new MySprite
    {
        Type = SpriteType.TEXT,
        Data = "Line 1",
        Position = position,
        RotationOrScale = 0.8f /* 80 % of the font's default size */,
        Color = Color.Red,
        Alignment = TextAlignment.CENTER /* Center the text on the position */,
        FontId = "White"
    };
    // Add the sprite to the frame
    frame.Add(sprite);

    // Move our position 20 pixels down in the viewport for the next line
    position += new Vector2(0, 20);

    // Here we add our clipping sprite. This is a simple rectangle. Nothing will be drawn outside it.
    // We create a rectangle that is covering the first half of the next line, cutting it off in the 
    // middle. 
    sprite = MySprite.CreateClipRect(new Rectangle(0, (int)position.Y - 16, (int)position.X, (int)position.Y + 16));
    // Add the sprite to the frame
    frame.Add(sprite);

    // Create our second line, we'll just reuse our previous sprite variable - this is not necessary, just
    // a simplification in this case.
    sprite = new MySprite
    {
        Type = SpriteType.TEXT,
        Data = "Line 2",
        Position = position,
        RotationOrScale = 0.8f,
        Color = Color.Blue,
        Alignment = TextAlignment.CENTER,
        FontId = "White"
    };
    // Add the sprite to the frame
    frame.Add(sprite);
}
```
There is an alternative way to set the clipping rectangle, depending on your needs. It can also be done this way:

```cs
using (frame.Clip(0, (int)position.Y - 16, (int)position.X, (int)position.Y + 16))
{
    // Create our second line, we'll just reuse our previous sprite variable - this is not necessary, just
    // a simplification in this case.
    sprite = new MySprite
    {
        Type = SpriteType.TEXT,
        Data = "Line 2",
        Position = position,
        RotationOrScale = 0.8f,
        Color = Color.Blue,
        Alignment = TextAlignment.CENTER,
        FontId = "White"
    };
    // Add the sprite to the frame
    frame.Add(sprite);
}
```
This will add the specified clipping sprite to the frame, and when the scope of the using exits, it will add a clear clip sprite.

### The Color Settings

As mentioned all the way at the top, the user can specify the background and foreground colors of the text surface. We can access these in our scripts through the `ScriptBackgroundColor` and `ScriptForegroundColor` properties of [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface). Let's modify our script so the background grid takes the configured foreground color rather than a hardcoded one. We'll still modify the color to have 66 % opacity, this is what Keen uses.

```csharp
    // Create background sprite
    var sprite = new MySprite()
    {
        Type = SpriteType.TEXTURE,
        Data = "Grid",
        Position = _viewport.Center,
        Size = _viewport.Size,
        Color = _drawingSurface.ScriptForegroundColor.Alpha(0.66f),
        Alignment = TextAlignment.CENTER
    };
    // Add the sprite to the frame
    frame.Add(sprite);
```

That's it. Play around with the background- and foreground colors in the control panel to see the differences it makes.

### Configuring a text surface to display sprites through code

As a final point, we will look at how you can set up a text surface to display sprites automatically from your script, without having the user need to configure them manually.

```csharp
public void PrepareTextSurfaceForSprites(IMyTextSurface textSurface)
{
    // Set the sprite display mode
    textSurface.ContentType = ContentType.SCRIPT;
    // Make sure no built-in script has been selected
    textSurface.Script = "";
}
```

### Final Code Listing
```csharp
IMyTextSurface _drawingSurface;
RectangleF _viewport;

// Script constructor
public Program()
{
    // Me is the programmable block which is running this script.
    // Retrieve the Large Display, which is the first surface
    _drawingSurface = Me.GetSurface(0);

    // Set the continuous update frequency of this script
    Runtime.UpdateFrequency = UpdateFrequency.Update100;

    // Calculate the viewport by centering the surface size onto the texture size
    _viewport = new RectangleF(
        (_drawingSurface.TextureSize - _drawingSurface.SurfaceSize) / 2f,
        _drawingSurface.SurfaceSize
    );
 
    // Make the text surface display sprites
    PrepareTextSurfaceForSprites(_drawingSurface);
}

// Main Entry Point
public void Main(string argument, UpdateType updateType)
{
    // Begin a new frame
    var frame = _drawingSurface.DrawFrame();

    // All sprites must be added to the frame here
    DrawSprites(ref frame);

    // We are done with the frame, send all the sprites to the text panel
    frame.Dispose();
}

// Drawing Sprites
public void DrawSprites(ref MySpriteDrawFrame frame)
{
    // Create background sprite
    var sprite = new MySprite()
    {
        Type = SpriteType.TEXTURE,
        Data = "Grid",
        Position = _viewport.Center,
        Size = _viewport.Size,
        Color = _drawingSurface.ScriptForegroundColor.Alpha(0.66f),
        Alignment = TextAlignment.CENTER
    };
    // Add the sprite to the frame
    frame.Add(sprite);

    // Set up the initial position - and remember to add our viewport offset
    var position = new Vector2(256, 20) + _viewport.Position;
    
    // Create our first line
    sprite = new MySprite()
    {
        Type = SpriteType.TEXT,
        Data = "Line 1",
        Position = position,
        RotationOrScale = 0.8f /* 80 % of the font's default size */,
        Color = Color.Red,
        Alignment = TextAlignment.CENTER /* Center the text on the position */,
        FontId = "White"
    };
    // Add the sprite to the frame
    frame.Add(sprite);
    
    // Move our position 20 pixels down in the viewport for the next line
    position += new Vector2(0, 20);

    // Here we add our clipping sprite. This is a simple rectangle. Nothing will be drawn outside it.
    // We create a rectangle that is covering the first half of the next line, cutting it off in the 
    // middle. 
    sprite = MySprite.CreateClipRect(new Rectangle(0, (int)position.Y - 16, (int)position.X, (int)position.Y + 16));
    // Add the sprite to the frame
    frame.Add(sprite);
    
    // Create our second line, we'll just reuse our previous sprite variable - this is not necessary, just
    // a simplification in this case.
    sprite = new MySprite()
    {
        Type = SpriteType.TEXT,
        Data = "Line 1",
        Position = position,
        RotationOrScale = 0.8f,
        Color = Color.Blue,
        Alignment = TextAlignment.CENTER,
        FontId = "White"
    };
    // Add the sprite to the frame
    frame.Add(sprite);
}

// Auto-setup text surface
public void PrepareTextSurfaceForSprites(IMyTextSurface textSurface)
{
    // Set the sprite display mode
    textSurface.ContentType = ContentType.SCRIPT;
    // Make sure no built-in script has been selected
    textSurface.Script = "";
}
```