using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject {

	List<Observer> _Observers = new List<Observer>( );

    public void Attach( Observer observer ) {
        _Observers.Add( observer );
    }

    public void Detach( Observer observer ) {
        _Observers.Remove( observer );
    }

    public void Notify( ) {
        foreach( Observer observer in _Observers ) {
            observer.Update( );
        }
    }
}
