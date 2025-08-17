using System;
using Godot;

public partial class ResumeButton : BaseButton
{
    protected sealed override void _on_pressed()
    {
        GD.Print("Resume button");
        GameManager.UnPauseGame();
        // TODO
    }
}
