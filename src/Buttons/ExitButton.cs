using System;
using Godot;

public partial class ExitButton : BaseButton
{
    protected sealed override void _on_pressed()
    {
        GD.Print("Exit button");
        // TODO
    }
}
