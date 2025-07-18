using Assets.Code.Battle;
using System;

public interface GameState
{
    void Start(Action<GameStateController.GameStates> onEndedCallback);
    void Stop();
}
