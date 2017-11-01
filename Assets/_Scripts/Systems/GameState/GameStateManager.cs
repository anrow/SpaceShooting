using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;
using StateManagement.GameState;

public class GameStateManager : GameState {

	private StateManager<GameState> SM_GameState = null;
    
    public void GameStateUpdate( ) {
        SM_GameState.UpdateState( );
    }

    public void CheckGameState( ) {
      
        switch( gameState ) {
            
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

    public void Init( ) {
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
