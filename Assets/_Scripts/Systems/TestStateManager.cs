using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;
using System;

public class TestStateManager : State<GameState> {

    private static TestStateManager instance;

    private TestStateManager( ) {
        if( instance != null ) {
            return;
        }
        instance = this;
    }

    public static TestStateManager Instance {
        get {
            if( instance == null ) {
                new TestStateManager( );
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
    }

    
}
