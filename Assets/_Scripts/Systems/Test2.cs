using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : State<TestBase> {

	public override void EnterState( ) {
        
		Debug.Log("Entering test 2 state");
	}

	public override void UpdateState() {
        
		if (Input.GetKeyDown( KeyCode.X ) ) {
			StateManager.SetState<Test1>( );
		}
	}

	public override void ExitState( ) {
		Debug.Log("Exiting test 2 state");
	}
}
