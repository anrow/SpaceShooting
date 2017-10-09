using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

    protected static InputController instance;

    public static InputController Instance {
        get {
            if( instance == null ) {

                instance = (InputController)FindObjectOfType( typeof(InputController) );

            }
            return instance;
        }
        
    }

    static public bool OnShoot( ) {
        if( Input.GetKeyDown( KeyCode.LeftControl ) ) {
            return true;
        }
        return false;
    }

    public Vector3 MoveDir(  ) {
        if( Input.GetAxis( "Horizontal" ) != 0 || 
            Input.GetAxis( "Vertical" ) != 0 
           ) {
            return new Vector3( Input.GetAxis( "Horizontal" ), 0, Input.GetAxis( "Vertical" ) );
        }
        
        return Vector3.zero;
    }

    void Update( ) {
    }
}
