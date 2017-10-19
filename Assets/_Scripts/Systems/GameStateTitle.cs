using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;
using System;

public class GameStateTitle : State<GameState> {

    private static GameStateTitle instance;

    private GameStateTitle( ) {
        if( instance != null ) {
            return;
        }
        instance = this;
    }

    public static GameStateTitle Instance {
        get {
            if( instance == null ) {
                new GameStateTitle( );
            }
            return instance;
        }
    }

    public override void EnterState( GameState _state ) {
        Debug.Log( "EnterTestState" );
    }

    public override void ExitState( GameState _state ) {
        Debug.Log( "ExitsTestState" );
    }

    public override void UpdateState( GameState _state ) {
        if( _state.gameState == 2 ) {
            _state.stateManager.SetState( GameStatePlaying.Instance );
            Debug.Log( "Play" );
        } 
        /*if( !_state.switchState ) {
            _state.stateManager.SetState( GameStatePlaying.Instance );
            Debug.Log( "play" );
        }*/
    }

    
}