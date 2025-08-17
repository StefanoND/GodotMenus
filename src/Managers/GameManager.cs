using System;
using Godot;

public partial class GameManager : Node
{
    public static EGameState GameState
    {
        get { return _gameState; }
    }

    public static void StartGame()
    {
        _gameState = EGameState.InGameUnpausedState;
    }

    public static void UnPauseGame()
    {
        _gameState = EGameState.InGameUnpausedState;
    }

    public static void PauseGame()
    {
        _gameState = EGameState.InGamePausedState;
    }

    private static EGameState _gameState = EGameState.MainMenuState;
}
