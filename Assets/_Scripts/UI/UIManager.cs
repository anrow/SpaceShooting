using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class UIManager : MonoBehaviour {

    public TitleUI titleUI;
    //public PlayUI playUI;
    //public PauseUI pauseUI;
    //public GameoverUI gameoverUI;

    protected GameObject m_RootUI = null;

    private bool isActive = true;

    private void Awake( ) {
        if( titleUI = null ) {
            titleUI = GameObject.FindGameObjectWithTag( "UI_Title" ).GetComponent<TitleUI>( );
        }
    }

    public bool IsVisable( ) {
        return isActive;
    }

    public virtual void OnShow( ) {
        m_RootUI.SetActive( true );
        isActive = true;
    }

    public virtual void OnHide( ) {
        m_RootUI.SetActive( false );
        isActive = false;
    }

    public virtual void Init( ) {
    }

    public virtual void Release( ) {
    }
    public virtual void Update( ) {
    }
}