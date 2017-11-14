using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Object {

    private static GameManager instance;

    public static GameManager Instance {
        get {
            if( instance == null ) {

                instance = new GameManager( );

                DontDestroyOnLoad( GameManager.instance );
            }
            return instance;
        }
    }
    
	private CharacterSystem m_CharacterSystem = null;

	private StageSystem m_StageSystem = null;

	public void Initinal( ) {

		m_CharacterSystem = new CharacterSystem( this );

		m_StageSystem = new StageSystem( this );

	}

    public void Update( ) {

		m_CharacterSystem.Update( );

		m_StageSystem.Update( );
    }

    public void GamePause( ) {
    }
    
    public void GameOver( ) {
    } 
}
