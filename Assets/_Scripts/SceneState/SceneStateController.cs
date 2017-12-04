using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController {

    private ISceneState m_State;

    private bool isRunBegin = false;

    public SceneStateController( ) { }

    public void SetState( ISceneState _NewState, string _LoadSceneName ) {

        isRunBegin = false;
	    
        if( SceneManager.GetActiveScene( ).name != _LoadSceneName ) {
       	    LoadScene( _LoadSceneName );
        }
        
        if( m_State != null ) {
            m_State.ExitState( );
        }
       
        m_State = _NewState;

    }

    private void LoadScene( string _LoadSceneName ) {

        if( _LoadSceneName == null ) {
            return;
        }

        SceneManager.LoadScene( _LoadSceneName );
    }

    public void UpdateState( ) {
        
        if( m_State != null && isRunBegin == false ) {

            m_State.EnterState( );

            isRunBegin = true;
        }

		if( m_State != null && isRunBegin == true ) {
            
            m_State.UpdateState( );

        }
    }

}
