using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameState : ISceneState {

    GameLoopController m_GameLoopControler;

    public MainGameState( SceneStateController _Controller ) : base( _Controller ) {
        this.StateName = "MainGame";
        this.EM_SceneState = ENUM_SceneState.MainGame;
    }

	public override void EnterState( ) { 
     
        Debug.Log( "EnterMainGame" );
	}

	public override void UpdateState( ) {
	    if( Input.GetKeyDown( KeyCode.UpArrow ) ) {
            m_Controller.SetState( new TitleState( m_Controller ), "Title" );
        }
	}

}
