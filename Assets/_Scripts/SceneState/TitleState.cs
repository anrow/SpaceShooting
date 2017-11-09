using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleState : SceneState {
	
    public TitleState( SceneStateController Controller ) : base( Controller ) {
        this.StateName = "Title";
    }

    public override void EnterState( ) {
		Debug.Log("Title");
		//GameObject CanvasObj = UnityTool.FindObjInName( "Canvas" );
		
		//Button btn = GameObject.Find("StartButton").GetComponent<Button>();
		
		//Debug.Log( CanvasObj );
		
		//Button btn = UITool.GetUIComponent<Button>( CanvasObj, "StartButton" );
		
		//Debug.Log( btn );
		
		GameObject player = GameObject.Find( "Player" );
		
		Debug.Log( player );
    }

    private void OnStartButtonClick( Button _btn ) {
        m_Controller.SetState( new MainGameState( m_Controller ), "MainGame" );
    }
}
