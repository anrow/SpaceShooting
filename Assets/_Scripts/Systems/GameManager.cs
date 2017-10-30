using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameStateManager))]

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
			UI_Manager = gameObject.transform.Find( "UI_Canvas" ).GetComponent<UIManager>( );
		}
       
    }

    void Start( ) {
        GS_Manager.SetGameStart( );
    }

    void Update( ) {
        
        GS_Manager.CheckGameStateUpdate( );

    }
        
}
