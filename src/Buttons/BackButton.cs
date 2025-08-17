using System;
using Godot;

public partial class BackButton : BaseButton
{
    protected sealed override void _on_pressed()
    {
        GD.Print("Back button");
        // TODO
    }
}
