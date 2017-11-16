using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

    public Player( ) { }

    protected bool isMoveX = false;

    protected bool isMoveZ = false;

    public void HandleInput( ) {

        if( Input.GetAxis( "Horizontal" ) != 0 ) {
            isMoveX = true;
        }
        if( Input.GetAxis( "Vertical" ) != 0 ) {
            isMoveZ = true;
        }
    }

    public override void Movement( Rigidbody _Rigidbody, float tilt ) {

        float axisX = Input.GetAxis( "Horizontal" );

        float axisZ = Input.GetAxis( "Vertical" );

        if( isMoveX ) {
            _Rigidbody.velocity = new Vector3( axisX * speed, 0, _Rigidbody.velocity.z );

            //Z方向の回転//
            _Rigidbody.rotation = Quaternion.Euler( _Rigidbody.rotation.x, 0, axisX * -tilt );
        }  
        //Z軸の移動
        if( isMoveZ ) {
             _Rigidbody.velocity = new Vector3( _Rigidbody.velocity.x, 0, axisZ * speed );
        }
    }

    public override void Attack( Character AttackTarget ) {

		BulletShoot( );

	}

	public override void UnderAttack( Character _Attacker ) {
		
	}

}
