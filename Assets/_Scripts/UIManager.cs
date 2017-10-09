using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    [SerializeField]
    private PlayerController player;

    [SerializeField]
    private ShipController ship;

    [SerializeField]
    private AsteriodController asteriod;

    [SerializeField]
    private ScoreLabel scoreLabel;

    [SerializeField]
    private LifePanel lifePanel;
   
	// Use this for initialization
	void Start( ) {
		
	}
	
	// Update is called once per frame
	void Update( ) {
        
		//lifePanel.UpdateLife( player.Life( ) );

        //scoreLabel.UpdateScore( );
        
	}

   

}
