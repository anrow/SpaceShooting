using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem {

    private static GameSystem instance;

    public static GameSystem Instance {
        get {
            if( instance == null ) {
                instance = new GameSystem( );
            }
            return instance;
        }
    }

    private CharacterSystem m_CharacterSystem = null;

    private StageSystem m_StageSystem = null;

    public void Initinalize( ) {
        m_CharacterSystem = new CharacterSystem( this );
        m_StageSystem = new StageSystem( this );
        Debug.Log( m_CharacterSystem );
    }

    public void AddEnemy( IEnemy _Enemy ) {
        m_CharacterSystem.AddEnemy( _Enemy );
    }

}
