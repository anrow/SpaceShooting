using UnityEngine;
using System.Collections;
using System;

public class IEnemy : ICharacter {

	public IEnemy( ) {
    }

    public override void Movement( ENUM_Enemy _EnemyType, Rigidbody _Rigidbody, float tilt ) {
        switch( _EnemyType ) {
		case ENUM_Enemy.Red:
			
                break;
        }
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



