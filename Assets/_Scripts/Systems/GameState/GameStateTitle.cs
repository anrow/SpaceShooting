using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement.GameState;

public class GameStateTitle : State<GameState> {
	public override void EnterState( ) {
		Debug.Log ("Enter Title");
	}
	public override void UpdateState( ) {
		
	}
	public override void ExitState( ) {
		Debug.Log ("Exit Title");
	}
}

