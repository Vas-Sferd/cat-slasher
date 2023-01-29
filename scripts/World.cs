using Godot;
using System;

public class World : Control
{
    [Export]
    public double position = 0.5;

    public override void _Ready()
    {
        var viewport = GetViewport();
        viewport.Connect("size_changed", this, "_Resize");
    }

    public void _Resize()
    {
        // Todo доделать масштабирование, используя 
        // https://godotforums.org/d/20245-help-with-viewport-and-multiple-resolutions/2
        GD.Print("Size changed");
    }
}
