using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {
    
    private GameSystem m_GameSystem;

    public GameManager( ) { }

    private void Awake( ) {
        m_GameSystem = new GameSystem( );
    }

    private void Start( ) {
        m_GameSystem.Initinalize( );
    }
}
