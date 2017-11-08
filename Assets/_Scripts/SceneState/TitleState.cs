using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleState : SceneState {

    public TitleState( SceneStateController Controller ) : base( Controller ) {
        this.StateName = "Title";
    }

    public override void EnterState( ) {

        Button btn = GameObject.Find( "StartButton" ).GetComponent<Button>( );

        if( btn != null ) {
            btn.onClick.AddListener( ( ) => OnStartButtonClick( btn ) );
        }
    }

    private void OnStartButtonClick( Button _btn ) {
        m_Controller.SetState( new MainGameState( m_Controller ), "MainGame" );
    }
}
