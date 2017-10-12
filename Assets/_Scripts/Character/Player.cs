using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

    protected Rigidbody rb;

    //生成した弾丸のトランスフォーマー
    protected Transform shotTrans;

    //プレーヤーの最大ライフポイント
    protected const int DEFAULT_LIFE = 5;
 
    void Awake( ) {

        SetGameObject( this.gameObject );

        rb = this.gameObject.GetComponent<Rigidbody>( );

        shotTrans = GameObject.FindGameObjectWithTag( "PlayerShotTrans" ).transform;
        
        life = DEFAULT_LIFE; 
    }
}
