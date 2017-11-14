using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : Character {

	public Player( ) { 
		
	}

	public override void Attack( Character AttackTarget ) {

		BulletShoot( );

	}

	public override void UnderAttack( Character _Attacker ) {
		
	}

}
