using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;

public class GameState : MonoBehaviour {

    public enum EM_GameState {
        GS_NULL,
        GS_TITLE,
        GS_PLAYING,
        GS_PAUSE,
        GS_GAMEPVER
    }

    public bool switchState = false;
    public float gameTimer;
    public int second = 0;

    public int gameState = (int)EM_GameState.GS_NULL;

    public StateManager<GameState> stateManager { get; set; }

    private void Start( ) {
        stateManager = new StateManager<GameState>( this );
        stateManager.SetState( GameStateTitle.Instance );
        gameTimer = Time.time;
    }  

    void Update( ) {
        if( Time.time > gameTimer + 1 ) {
            gameTimer = Time.time;
            second++;
            Debug.Log( second );
        }
        if( second == 5 ) {
            second = 0;
            
        }

        if( Input.GetKeyDown( KeyCode.UpArrow ) ) {
            Debug.Log( "Press Up" );
            gameState = 1;
        }
        if( Input.GetKeyDown( KeyCode.DownArrow ) ) {
            gameState = 2;
        }
        gameState = 0;
        stateManager.Update( );
    }
}
