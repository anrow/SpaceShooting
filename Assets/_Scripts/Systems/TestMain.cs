using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;

public class TestMain : MonoBehaviour {
	
	private StateManager<TestBase> stateManager;

	void Start( ){
		stateManager = new StateManager<TestBase>( new Test1() );
	}

	void Update( ) {
		stateManager.UpdateState( );
	}
}
