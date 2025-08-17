#if TOOLS
using Godot;

[Tool]
public partial class RegisterAutoloads : EditorPlugin
{
    private const string MENU_MANAGER = "MenuManager";
    private const string GAME_MANAGER = "GameManager";
    private const string GAME_STATE = "GameState";

    public override void _EnablePlugin()
    {
        AddAutoloadSingleton(MENU_MANAGER, "res://Scenes/Managers/MenuManager.tscn");
        AddAutoloadSingleton(GAME_MANAGER, "res://Scenes/Managers/GameManager.tscn");
        AddAutoloadSingleton(GAME_STATE, "res://src/Enums/EGameState.cs");
    }

    public override void _DisablePlugin()
    {
        RemoveAutoloadSingleton(MENU_MANAGER);
    }
}
#endif
