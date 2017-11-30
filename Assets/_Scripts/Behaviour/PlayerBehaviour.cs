using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    [SerializeField]
    private Rigidbody m_Rb;

    [SerializeField]
    private float m_Tilt;

    private IPlayer m_Player = new IPlayer( );

	// Use this for initialization
	void Start( ) {
		m_Player.SetGameObject( this.gameObject );
	}
	
	// Update is called once per frame
	void Update( ) {
        
		m_Player.HandleInput( );
        m_Player.Movement( m_Rb, m_Tilt );
	}
}
