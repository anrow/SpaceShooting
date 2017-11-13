using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleState : SceneState {
	
    public TitleState( SceneStateController _Controller ) : base( _Controller ) {
        this.StateName = "Title";
    }

    public override void EnterState( ) {
		
		GameObject CanvasObj = UnityTool.FindObjInName( "Canvas" );

		Button btn = UITool.GetUIComponent<Button>( CanvasObj, "StartButton" );

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
