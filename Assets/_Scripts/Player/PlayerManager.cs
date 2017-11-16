using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    [SerializeField]
    private Rigidbody m_Rb;

    [SerializeField]
    private float m_Tilt;

    private Player m_Player;

    private void Start( ) {

        m_Player = GetComponent<Player>( );

        m_Player.SetGameObject( this.gameObject );
    }

    private void Update( ) {
        
        m_Player.Movement( m_Rb, m_Tilt );
    }

}
