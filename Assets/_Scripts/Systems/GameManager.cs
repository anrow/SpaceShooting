using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private GameStateManager GS_Manager;

    [SerializeField]
    private UIManager UI_Manager;

    void Awake( ) {
        if( GS_Manager == null ) {
            GS_Manager = this.gameObject.GetComponentInChildren<GameStateManager>( );
        }
        if( UI_Manager == null ) {
            UI_Manager = GameObject.FindGameObjectWithTag( "UIManager" ).GetComponent<UIManager>( );
        }
    }

    void Start( ) {
        GS_Manager.Init( );
    }

    void Update( ) {
        
        GS_Manager.CheckGameState( );
        GS_Manager.GameStateUpdate( );
    }
        
}
