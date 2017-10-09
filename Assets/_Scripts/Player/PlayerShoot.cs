using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    private InputController InputCtrl;

    //生成した弾丸のトランスフォーマー
    [SerializeField]
    private Transform shotTrans;

    void Update( ){
        if( InputController.OnShoot( ) ) {
            Debug.Log( "shoot" );
        }
    }
}
