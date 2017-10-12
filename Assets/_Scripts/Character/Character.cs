using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

    protected GameObject _GameObject = null;

    protected bool _beKilled;

    protected bool _checkKilled = false;

    protected bool _canRemove = false;

    protected const float _removeTimer = 1f;

    protected int life;

    public Character( ) { }

    public void SetGameObject( GameObject obj ) {
        _GameObject = obj;
    }

    public void Release( GameObject obj ) {

        _GameObject = obj;
        
        Destroy( obj );
    }
}
