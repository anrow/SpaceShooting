using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IGameSystem {

    protected GameSystem m_GameSystem = null;

    public IGameSystem( GameSystem _GameSystem ) {
        _GameSystem = m_GameSystem;

    }

	public virtual void Initinalize( ) { }

	public virtual void Update( ) { }

	public virtual void Release( ) { }
}
