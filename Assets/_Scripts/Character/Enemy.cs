using UnityEngine;
using System.Collections;
using System;

public class Enemy : Character {

	public Enemy( ) { }

    public override void Movement( Rigidbody _Rigidbody, float tilt ) {
        
    }

    public override void Attack( Character AttackTarget ) {

		BulletShoot( );

	}

	public override void UnderAttack( Character Attacker ) {
	}
}



