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
     
        Debug.Log ( "IEnemy init" );
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



