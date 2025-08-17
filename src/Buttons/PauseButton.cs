using System;
using Godot;

public partial class PauseButton : BaseButton
{
    protected sealed override void _on_pressed()
    {
        GD.Print("Pause button");
        GameManager.PauseGame();
        // TODO
    }
}
