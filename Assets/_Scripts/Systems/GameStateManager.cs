using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;

public class GameStateManager : GameState {

	private StateManager<GameState> SM_GameState;

	void Start( ) {
		SM_GameState = new StateManager<GameState>( new GameStateTitle( ) );
	}

	void Update( ) {
		//SM_GameState.UpdateState ();
		if (Input.GetKeyDown (KeyCode.A)) {
			SM_GameState.SetState<GameStatePause> ();
		}
	}

}
