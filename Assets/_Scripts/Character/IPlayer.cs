﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPlayer : ICharacter {

    public bool isMoveX = false;
    
    public bool isMoveZ = false;

    public GameObject InstanceObj;

    public IPlayer( ) {
        Initinalize( );
    }

    public void HandleInput( ) {

        if( Input.GetAxis( "Horizontal" ) != 0 ) {
            isMoveX = true;
        } else {
            isMoveX = false;
        }
        if( Input.GetAxis( "Vertical" ) != 0 ) {
            isMoveZ = true;
        } else {
            isMoveZ = false;
        }
    }

    public override void Movement(  Rigidbody _Rigidbody, float _Tilt ) {
        
        float axisX = Input.GetAxis( "Horizontal" );

        float axisZ = Input.GetAxis( "Vertical" );

        if( isMoveX ) {

            _Rigidbody.velocity = new Vector3( axisX * speed, 0, _Rigidbody.velocity.z );

            //Z方向の回転//
            _Rigidbody.rotation = Quaternion.Euler( _Rigidbody.rotation.x, 0, axisX * -_Tilt );
        }  
        //Z軸の移動
        if( isMoveZ ) {
             _Rigidbody.velocity = new Vector3( _Rigidbody.velocity.x, 0, axisZ * speed );
        }
    }

    public override void Attack( ICharacter AttackTarget ) {

		BulletShoot( );

	}

	public override void UnderAttack( ICharacter _Attacker ) {
		
	}

    public override void Initinalize( ) {
        
    }

    public override void Update( ) {
        HandleInput( );
    }
}
