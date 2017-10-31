using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;
using StateManagement.GameState;

public class GameStateManager : GameState {

	private StateManager<GameState> SM_GameState = null;

    public enum EM_GameState {
        GAME_STATE_TITLE,
        GAME_STATE_PAUSE,
        GAME_STATE_PLAY,
        GAME_STATE_GAMEOVER
	};

    private EM_GameState em_GameState = EM_GameState.GAME_STATE_TITLE;

    public EM_GameState gameState{ get{ return em_GameState; } }
        
    public void CheckGameStateUpdate( ) {
      
        switch( em_GameState ) {
            
            case EM_GameState.GAME_STATE_TITLE:
                SetGameTitle( );
                break;
            case EM_GameState.GAME_STATE_PAUSE:
                SetGamePause( );
                break;
            case EM_GameState.GAME_STATE_PLAY:
                SetGamePlay( );
                break;
            case EM_GameState.GAME_STATE_GAMEOVER:
                SetGameOver( );
                break;

        }
    }

    public void SetGameStart( ) {
        SM_GameState = new StateManager<GameState>( new GameStateTitle( ) );
    }
    void SetGameTitle( ) {
         SM_GameState.SetState<GameStateTitle>( );
    }
    void SetGamePause( ) {
        SM_GameState.SetState<GameStatePause>( );
    }
    void SetGamePlay( ) {
        SM_GameState.SetState<GameStatePlay>( );
    }
    void SetGameOver( ) {
        SM_GameState.SetState<GameStateGameOver>( );
    }
}
