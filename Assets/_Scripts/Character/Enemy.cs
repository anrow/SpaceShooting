using UnityEngine;
using System.Collections;

public abstract class Enemy : Character {

	public Enemy( ) { }

	public override void Attack( Character AttackTarget ) {

		BulletShoot( );

	}

	public override void UnderAttack( Character Attacker ) {
	}
}



