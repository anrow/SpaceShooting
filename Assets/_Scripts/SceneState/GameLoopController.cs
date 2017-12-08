using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoopController : MonoBehaviour {

    SceneStateController m_SceneStateController = new SceneStateController( );

    void Awake( ) {
        DontDestroyOnLoad( this.gameObject );
    }

    void Start( ) {

		string nowStateName = SceneManager.GetActiveScene( ).name;

		m_SceneStateController.SetState( new TitleState( m_SceneStateController ), nowStateName );

    }

    void Update( ) {
        m_SceneStateController.UpdateState( );
    }
}
