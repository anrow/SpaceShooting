using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StateManagement;

public class UIManager : MonoBehaviour {

    [SerializeField]
    private ScoreLabel scoreLabel;

    [SerializeField]
    private LifePanel lifePanel;
    
    [SerializeField]
    private GameObject title;
	// Use this for initialization

    void SetVisble( GameObject _UIObj ) {
        _UIObj.SetActive( true );
    }

    public void SetVisbleTitle( ) {
        SetVisble( title );

    }
        
}
