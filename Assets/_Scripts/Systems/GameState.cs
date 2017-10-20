using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;

public class GameState : MonoBehaviour {

    public StateManager<GameState> stateManager { get; set; }

    private void Start( ) {
		
        stateManager = new StateManager<GameState> (this);
    }  

    void Update( ) {
		if (Input.GetKeyDown (KeyCode.Z)) {
			stateManager.SetState( GameStatePlaying.Instance );
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			stateManager.SetState( GameStateTitle.Instance );
		}
        stateManager.Update( );
    }
}
