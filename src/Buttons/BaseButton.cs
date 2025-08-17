using System;
using Godot;

public partial class BaseButton : Button
{
    protected virtual void _on_pressed()
    {
        GD.Print("Base button");
        // TODO
    }
}
