using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;
using System;

public class GameStatePlaying : State<GameState> {

    private static GameStatePlaying instance;

    private GameStatePlaying( ) {
        if( instance != null ) {
            return;
        }
        instance = this;
    }

    public static GameStatePlaying Instance {
        get {
            if( instance == null ) {
                new GameStatePlaying( );
            }
            return instance;
        }
    }

    public override void EnterState( GameState _state ) {
       Debug.Log( "EnterGameState" );
    }

    public override void ExitState( GameState _state ) {
        Debug.Log( "ExitGameState" );
    }

    public override void UpdateState( GameState _state ) {
        if( _state.gameState == 1 ) {
            _state.stateManager.SetState( GameStateTitle.Instance );
            Debug.Log( "title" );
        }
       /* if( _state.switchState ) {
            _state.stateManager.SetState( GameStateTitle.Instance );
            Debug.Log( "title" );
        }*/
        
    }

    
}