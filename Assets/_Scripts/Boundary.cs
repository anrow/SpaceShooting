using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {

    protected static Boundary instance;
 
    public static Boundary Instance {
        get {
           if( instance == null ) {
              instance = ( Boundary ) FindObjectOfType( typeof( Boundary ) );
     
              if( instance == null ) {
                 Debug.LogError("Boundary Instance Error");
              }
           }
           return instance;
        }
     }
    //ボーダーの距離
    [SerializeField]
    private float xMin, xMax, zMin, zMax;

    ////移動の範囲を設定（ボーダー）
    public void LimitBoundary( Rigidbody target ) { 
        target.position = new Vector3( 
            Mathf.Clamp( target.position.x, xMin, xMax ),
            target.position.y,
            Mathf.Clamp( target.position.z, zMin, zMax )
            );
    }

    private void OnTriggerExit( Collider other ) {
        Destroy( other.gameObject ); 
    }

}

