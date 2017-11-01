using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement.GameState;

public class GameStatePlay : State<GameState> {

    GameObject UI_Obj = null;

	public override void EnterState( ) {
        GameObject playUI = GameObject.FindGameObjectWithTag( "PlayUI" );
        UI_Obj = playUI;
        UI_Obj.SetActive( true );
		Debug.Log ("Enter Playing");
	}
	public override void UpdateState( ) {
		
	}
	public override void ExitState( ) {
        UI_Obj.SetActive( false );
		Debug.Log ("Exit Playing");
	}
}

