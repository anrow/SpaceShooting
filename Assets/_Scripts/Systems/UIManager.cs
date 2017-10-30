using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StateManagement;

public class UIManager : MonoBehaviour {
	
	private static UIManager instance;

	public static UIManager Instance {
		get {
			if( instance == null ) {
				instance = new UIManager( );
			}
			return instance;
		}

	}

    [SerializeField]
    private ScoreLabel scoreLabel;

    [SerializeField]
    private LifePanel lifePanel;
    
    [SerializeField]
    private GameObject title;
	// Use this for initialization

    void SetVisble( GameObject _obj ) {
        _obj.SetActive( true );
    }

    public void SetVisbleTitle( ) {
        SetVisble( title );
    }

	public void CheckUIStateUpdate( ) {

	}
        
}
