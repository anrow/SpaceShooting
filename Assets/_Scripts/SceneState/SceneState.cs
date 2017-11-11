using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneState {

    private string m_StateName = "SceneState";

    protected SceneStateController m_Controller = null;

    public string StateName {
        get {
            return m_StateName;
        }
        set {
            m_StateName = value;
        }
    }

    public SceneState( SceneStateController _Controller ) {
        m_Controller = _Controller;
    }

    public virtual void EnterState( ) { }
    public virtual void UpdateState( ) { }
    public virtual void ExitState( ) { }
        
}
