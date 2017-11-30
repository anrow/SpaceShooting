using UnityEngine;
using System.Collections;
using System;

public class IEnemy : ICharacter {

	public IEnemy( ) { }

    public override void Movement( Rigidbody _Rigidbody, float tilt ) {
        
    }

    public override void Attack( ICharacter AttackTarget ) {

		BulletShoot( );

	}

	public override void UnderAttack( ICharacter Attacker ) {
	}

    public override void Initinalize( ) {
    
    }

    public override void Update( ) {
        
    }
}

public enum ENUM_Enemy {
    Red,
    Yellow,
    Blue,
    Green,
    Balck
}



