using Godot;

public partial class MenuManager : Node
{
    [Export]
    private Node2D _mainMenu;

    [Export]
    private Node2D _optionsMenu;

    [Export]
    private Node2D _inGameMenu;

    [Export]
    private Node2D _pauseMenu;

    public override void _PhysicsProcess(double delta)
    {
        switch (GameManager.GameState)
        {
            default:
            case EGameState.MainMenuState:
                SetMenuVisibility(_mainMenu, true);
                SetMenuVisibility(_optionsMenu, false);
                SetMenuVisibility(_inGameMenu, false);
                SetMenuVisibility(_pauseMenu, false);
                break;
            case EGameState.MainMenuOptionsState:
                SetMenuVisibility(_mainMenu, false);
                SetMenuVisibility(_optionsMenu, true);
                SetMenuVisibility(_inGameMenu, false);
                SetMenuVisibility(_pauseMenu, false);
                break;
            case EGameState.InGameUnpausedState:
                SetMenuVisibility(_mainMenu, false);
                SetMenuVisibility(_optionsMenu, false);
                SetMenuVisibility(_inGameMenu, true);
                SetMenuVisibility(_pauseMenu, false);
                break;
            case EGameState.InGamePausedState:
                SetMenuVisibility(_mainMenu, false);
                SetMenuVisibility(_optionsMenu, false);
                SetMenuVisibility(_inGameMenu, false);
                SetMenuVisibility(_pauseMenu, true);
                break;
            case EGameState.InGamePausedOptionsState:
                SetMenuVisibility(_mainMenu, false);
                SetMenuVisibility(_optionsMenu, true);
                SetMenuVisibility(_inGameMenu, false);
                SetMenuVisibility(_pauseMenu, false);
                break;
        }
        base._PhysicsProcess(delta);
    }

    private void SetMenuVisibility(Node2D menu, bool visible)
    {
        if (menu.Visible != visible)
        {
            menu.Visible = visible;
        }
    }
}
