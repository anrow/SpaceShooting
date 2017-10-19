using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;
using System;

public class GameStateManager : State<GameState> {

    private static GameStateManager instance;

    private GameStateManager( ) {
        if( instance != null ) {
            return;
        }
        instance = this;
    }

    public static GameStateManager Instance {
        get {
            if( instance == null ) {
                new GameStateManager( );
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
 
    }

    
}
