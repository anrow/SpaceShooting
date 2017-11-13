using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StateManagement;
using StateManagement.GameState;

public class GameStateTitle : State<GameState> {

    private StateManager<GameState> SM_GameState = null;

    GameObject UI_Obj = null;

    private void OnStartBtnClick( Button _btn ) {
       SM_GameState.SetState<GameStatePlay>( );
    }

	public override void EnterState( ) {
        SM_GameState = new StateManager<GameState>( new GameStateTitle( ) ); 
        GameObject titleUI = GameObject.FindGameObjectWithTag( "TitleUI" );
        UI_Obj = titleUI;
        UI_Obj.SetActive( true );

       
		Debug.Log ("Enter Title");
	}
	public override void UpdateState( ) {

	    Button startBtn = UI_Obj.GetComponent<Button>( );

        if( startBtn != null ) {
            startBtn.onClick.AddListener( () => OnStartBtnClick( startBtn ) );
        }
	}
	public override void ExitState( ) {
        UI_Obj.SetActive( false );
		Debug.Log ("Exit Title");
	}
}

