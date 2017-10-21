using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;

public class TestMain : MonoBehaviour {
	
	private StateManager<TestBase> sm_base;

	void Start( ) {
		sm_base = new StateManager<TestBase>( new Test1( ) );
	}

	void Update( ) {
        
		sm_base.UpdateState( );
       
	}
}
