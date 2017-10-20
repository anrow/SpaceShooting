using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : State<TestBase>{

	public override void EnterState( ) {
		Debug.Log("Entering test 1 state");
	}

	public override void UpdateState() {
		if (Input.GetKeyDown( KeyCode.Z ) ) {
			StateManager.SetState<Test2>( );
		}
	}

	public override void ExitState( ) {
		Debug.Log("Exiting test1 state");
	}
}
