using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : Singleton<GameSystem> {

    private CharacterSystem m_CharacterSystem = null;
 
    private StageSystem m_StageSystem = null;

    private void Start( ) {

		m_CharacterSystem = new CharacterSystem( this );
		
		m_StageSystem = new StageSystem( this );
        
    }

	private void Update( ) {
		m_CharacterSystem.Update( );
	}

	public void AddEnemy( IEnemy _Enemy ) {
		m_CharacterSystem.AddEnemy( _Enemy );
	}
}
