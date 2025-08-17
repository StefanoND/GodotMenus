using System;
using Godot;

public partial class PlayButton : BaseButton
{
    protected sealed override void _on_pressed()
    {
        GD.Print("Play button");
        GameManager.StartGame();
        // TODO
    }
}
