using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    //生成した弾丸のトランスフォーマー
    [SerializeField]
    private Transform shotTrans;

    void Start( ){

        shotTrans = GameObject.FindGameObjectWithTag( "PlayerShotTrans" ).transform;
        
    }

    void FixedUpdate( ){
        if( InputController.OnShoot( ) ) {
            Debug.Log( "shoot" );
        }
    }
}
