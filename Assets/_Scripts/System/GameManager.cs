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
    
	private CharacterSystem m_CharacterSystem = new CharacterSystem( instance );

	private StageSystem m_StageSystem = new StageSystem( instance );
    
    public void Initinal( ) {

        m_CharacterSystem.Initinal( );
        
		m_StageSystem.Initinal( );
	}

    public void Update( ) {

		m_CharacterSystem.Update( );
        
		m_StageSystem.Update( );
    }

}
