using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISceneState {

    private string m_StateName = "SceneState";

    private ENUM_SceneState m_SceneState = ENUM_SceneState.Null;

    protected SceneStateController m_Controller = null;

    public enum ENUM_SceneState {
        Null,
        Title,
        MainGame
    }

    public ENUM_SceneState EM_SceneState {
        get {
            return m_SceneState;
        }
        set {
            m_SceneState = value;
        }
    }

    public string StateName {
        get {
            return m_StateName;
        }
        set {
            m_StateName = value;
        }
    }

    public ISceneState( SceneStateController _Controller ) {
        m_Controller = _Controller;
    }

    public virtual void EnterState( ) { }
    public virtual void UpdateState( ) { }
    public virtual void ExitState( ) { }
        
}
