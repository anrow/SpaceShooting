using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed: MonoBehaviour {

    [SerializeField]
    private float m_Tilt;

    private Rigidbody m_Rb;

    private IEnemy m_Behaviour = new IEnemy( );

    private void Awake( ) {
        m_Behaviour.Initinalize( );
        GameSystem.Instance.AddEnemy( m_Behaviour );
        Debug.Log( m_Behaviour );
    }
    private void Start( ) {
        m_Rb = this.GetComponent<Rigidbody>( );
    }
    private void Update( ) {
        m_Behaviour.Movement( ENUM_Enemy.Red, 60 );
    }
}
