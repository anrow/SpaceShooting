using UnityEngine;
using System.Collections;
using System;

public class IEnemy : ICharacter {

    private EnemyMove m_Movement;

    public GameObject InstanceObj;

	public IEnemy( ) {
        Initinalize( );
    }

    public override void Movement( Rigidbody _Rigidbody, float tilt ) {
        
    }

    public override void Attack( ICharacter AttackTarget ) {

		BulletShoot( );

	}

	public override void UnderAttack( ICharacter Attacker ) {
	}

    public override void Initinalize( ) {
        InstanceObj = GameObject.FindObjectOfType<EnemyMove>( ).gameObject;
        m_Movement = this.InstanceObj.GetComponent<EnemyMove>( );
        m_Movement.a = 1;
        Debug.Log ( m_Movement.a );
    }

    public override void Update( ) {
        
    }
}

public enum ENUM_Enemy {
	Null,
    Red,
    Yellow,
    Blue,
    Green,
    Balck
}



