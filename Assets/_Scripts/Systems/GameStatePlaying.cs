using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;
using System;
using UnityEngine.SceneManagement;

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
       Debug.Log( "EnterPlayState" );
    }

    public override void ExitState( GameState _state ) {
		SceneManager.LoadScene ("Title");
        Debug.Log( "ExitPlayState" );
    }

    public override void UpdateState( GameState _state ) {
        
    }

    
}