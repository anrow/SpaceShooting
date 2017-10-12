using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurt : Player {

    void OnTriggerEnter( Collider col ) {
        life--;
        Debug.Log( "life : " + life );
    }
    
 }
