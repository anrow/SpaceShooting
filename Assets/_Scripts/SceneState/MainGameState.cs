using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameState : ISceneState {

    public MainGameState( SceneStateController _Controller ) : base( _Controller ) {
        this.StateName = "MainGame";
    }

	public override void EnterState( ) {
        Debug.Log( "EnterMainGame" );
        GameManager.Instance.Initinalize( );
    
	}

	public override void UpdateState( ) {
	
		//GameManager.Instance.Update( );
	}

}
