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
    
	public void Initinal( ) {
	}

    public void Update( ) {
    }

    public void GamePause( ) {
    }
    
    public void GameOver( ) {
    } 
}
