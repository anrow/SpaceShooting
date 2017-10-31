using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement.GameState;

public class GameStatePlay : State<GameState> {
	public override void EnterState( ) {
		Debug.Log ("Enter Playing");
	}
	public override void UpdateState( ) {
		
	}
	public override void ExitState( ) {
		Debug.Log ("Exit Playing");
	}
}

