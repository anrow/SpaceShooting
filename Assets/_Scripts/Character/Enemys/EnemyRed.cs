using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed: MonoBehaviour {

    [SerializeField]
    private float m_Tilt;

    private Rigidbody m_Rb;

    private IEnemy m_Behaviour = new IEnemy( );

	void OnEnable( ) {
		GameSystem.Instance.AddEnemy( m_Behaviour );
	}

    private void Awake( ) {
        m_Behaviour.Initinalize( );
    }
    private void Start( ) {
		
        m_Rb = this.GetComponent<Rigidbody>( );

    }
    private void Update( ) {
		if( m_Behaviour != null )
		m_Behaviour.Movement( ENUM_Enemy.Red, m_Rb, 60 );

		if (Input.GetKeyDown (KeyCode.Space)) {
			GameSystem.Instance.RemoveEenemy (m_Behaviour);
			Destroy (this.gameObject);
		}
    }
}
