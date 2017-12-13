using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleState : ISceneState {
	
    public TitleState( SceneStateController _Controller ) : base( _Controller ) {
        this.StateName = "Title";
        this.EM_SceneState = ENUM_SceneState.Title;
    }

    public override void EnterState( ) {
		Debug.Log( "EnterTitle" );
       
		GameObject CanvasObj = UnityTool.FindObjInName( "Canvas" );

		Button btn = UITool.GetUIComponent<Button>( CanvasObj, "StartButton" );
        Debug.Log ( btn );
		if( btn != null ) {
			btn.onClick.AddListener( ( ) => OnStartButtonClick( ) );
		}
    }

    public override void UpdateState( ) {
        
    }

    private void OnStartButtonClick( ) {
        m_Controller.SetState( new MainGameState( m_Controller ), "MainGame" );
    }
}
