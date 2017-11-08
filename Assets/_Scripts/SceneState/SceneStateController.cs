using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController {

    private SceneState m_State;

    private bool isRunBegin = false;

    public SceneStateController( ) { }

    public void SetState( SceneState _State, string LoadSceneName ) {

        isRunBegin = false;

        LoadScene( LoadSceneName );

        if( m_State != null ) {
            m_State.ExitState( );
        }

        m_State = _State;

    }

    private void LoadScene( string LoadSceneName ) {

        if( LoadSceneName == null ) {
            return;
        }

        SceneManager.LoadScene( LoadSceneName );
    }

    public void UpdateState( ) {

        

        if( m_State != null && isRunBegin == false ) {

            m_State.EnterState( );

            isRunBegin = true;
        }

        if( m_State != null ) {
            m_State.UpdateState( );
        }
    }

}
