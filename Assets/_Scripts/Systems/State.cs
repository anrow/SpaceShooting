using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;

public abstract class State<T> {
    
	protected StateManager<T> StateManager;

    public void SetStateManager( StateManager<T> _StateManager ) {
        this.StateManager = _StateManager;
    }

    public abstract void EnterState( ); 
    public abstract void UpdateState( );
    public abstract void ExitState( );

}
