using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : Player {
  
	void Update( ) {
	    if( life < 4 ) {
            Destroy( this );
        }
	}
}
