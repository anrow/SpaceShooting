using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState : SceneState {

    public BaseState( SceneStateController _Controller ) : base( _Controller ) {
        this.StateName = "BaseState";
    }

    public override void EnterState( ) {

    }

    public override void UpdateState( ) {
        m_Controller.SetState( new TitleState( m_Controller ), "Title" );
    }
}
