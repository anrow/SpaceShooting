using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement.GameState;

public class GameStateGameOver : State<GameState> {
	public override void EnterState( ) {
		Debug.Log ("Enter Over");
	}
	public override void UpdateState( ) {

	}
	public override void ExitState( ) {
		Debug.Log ("Exit Over");
	}
}
