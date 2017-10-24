using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameStateManager))]
public class GameManager : MonoBehaviour {

    [SerializeField]
    private GameStateManager GS_Manager;

    [SerializeField]
    private UIManager UI_Manager;
    void Start( ) {
        GS_Manager.GameTitle( );
    }
}
