using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;
using System;
using UnityEngine.SceneManagement;

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
        Debug.Log( "EnterTitleState" );
    }

    public override void ExitState( GameState _state ) {
		SceneManager.LoadScene ("Main");
        Debug.Log( "ExitsTitleState" );
    }

    public override void UpdateState( GameState _state ) {
	     
    }

    
}