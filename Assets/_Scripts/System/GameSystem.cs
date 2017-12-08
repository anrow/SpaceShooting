using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour {

    protected GameManager m_GameManager = null;

    public GameSystem( GameManager _GameManager ) {
        m_GameManager = _GameManager;
    }

	public virtual void Initinalize( ) { }

	public virtual void Update( ) { }

	public virtual void Release( ) { }
}
