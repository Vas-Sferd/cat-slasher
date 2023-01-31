using Godot;
using System;

public class World : Control
{
	[Export]
	public double position = 0.5;
	private Node2D WorldBackground;

	public override void _Ready()
	{
		WorldBackground = GetNode<Node2D>("WorldBackground");
		
		var viewport = GetViewport();
		viewport.Connect("size_changed", this, "_Resize");
		_Resize();
	}

	public void _Resize()
	{
		var windowAspectRatio = OS.WindowSize.x / OS.WindowSize.y;
		var backgroundAspectRatio = WorldBackground.Position.x / WorldBackground.Position.y;
		
		if (windowAspectRatio < backgroundAspectRatio)
		{
			GD.Print("Size changed here");
		}
		
		var newSize = OS.WindowSize * (1 / windowAspectRatio);
		GD.Print($"{newSize}");
		
		GetViewport().SetSizeOverride(true, newSize);
	}
}
