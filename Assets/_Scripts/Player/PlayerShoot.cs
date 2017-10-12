using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : Player {

    void FixedUpdate( ){
        if( InputController.OnShoot( ) ) {
            Debug.Log( "shoot" );
        }
    }
}
