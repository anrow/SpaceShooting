using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem {

    private CharacterSystem m_CharacterSystem = null;

    private StageSystem m_StageSystem = null;

    public void Initinalize( ) {
        m_CharacterSystem = new CharacterSystem( this );
        m_StageSystem = new StageSystem( this );
        Debug.Log( m_CharacterSystem );
    }

}
