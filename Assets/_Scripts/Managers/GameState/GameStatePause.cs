using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement.GameState;

public class GameStatePause : State<GameState> {
	public override void EnterState( ) {
		Debug.Log ("Enter Pause");
	}
	public override void UpdateState( ) {
		
	}
	public override void ExitState( ) {
		Debug.Log ("Exit Pause");
	}
}

