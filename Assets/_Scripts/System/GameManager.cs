using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {
    
    [SerializeField]
	private CharacterSystem m_CharacterSystem;

    [SerializeField]
	private StageSystem m_StageSystem;

    private void Awake( ) {
        Debug.Log( "ManagerAwake" );
        if( m_CharacterSystem == null ) {
            m_CharacterSystem = GameObject.FindObjectOfType<CharacterSystem>( );
        }
        if( m_StageSystem == null ) {
            m_StageSystem = GameObject.FindObjectOfType<StageSystem>( );
        }
    }

    public void Initinalize( ) {
        m_CharacterSystem.Initinalize( );
	}

    public void Update( ) {
    }

}
