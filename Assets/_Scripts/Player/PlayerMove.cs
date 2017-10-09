﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public static bool CanMove = true;
    public static bool CanRotate = true;

    private Rigidbody rb;

    public InputController InputCtrl;

	 //プレーヤーの移動速度
    [SerializeField]
    private float speed;

    //回転係数 tilt//
    [SerializeField]
    private float tilt;


	void Start( ) {

		rb = gameObject.GetComponent<Rigidbody>( );

        InputCtrl = GameObject.FindObjectOfType<InputController>( );

    }
	
	void FixedUpdate( ) {
        if( InputCtrl != null ) {
            HandleInput( );
        }

        HandleMovement( );
    }

    Vector3 HandleInput( ) {
        return InputCtrl.MoveDir( );
    }

    void HandleMovement( ) {

        if( InputCtrl.MoveDir( ).x != 0 ) {

            rb.velocity = new Vector3( InputCtrl.MoveDir( ).x * speed, 0, rb.velocity.z );

            //Z方向の回転//
            rb.rotation = Quaternion.Euler( rb.rotation.x, 0, InputCtrl.MoveDir( ).x * -tilt );
        }
         if( InputCtrl.MoveDir( ).z != 0 ) {
            rb.velocity = new Vector3( rb.velocity.x, 0, InputCtrl.MoveDir( ).z * speed );
        }
    }
}