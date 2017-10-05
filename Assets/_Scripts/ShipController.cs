using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float speed;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform[ ] shotTrans;

    
    //弾丸が生成する時間
    [SerializeField]
    private float nextBulletTime;

    //弾丸の生成速度率
    [SerializeField]
    private float bulletRate;

    [SerializeField]
    private GameObject enemyExplosion;

	void Awake( ) {
		rb = gameObject.GetComponent<Rigidbody>( );
	}
	void Start( ) {
		InvokeRepeating( "OnShoot", nextBulletTime, bulletRate );
	}
	
	void Update( ) {
         rb.velocity = new Vector3( 0, 0, 1 ) * -speed;
	}
    void FixedUpdate( ) {
       
	}
    void OnShoot( ) {
        for( int i = 0; i < shotTrans.Length; i++ ) {
		    //Instantiate( bullet, shotTrans[ i ].position, shotTrans[ i ].rotation );
        }
    }
    void OnTriggerEnter( Collider other ) {
        if( other.tag == "PlayerBullet" ) {
            Instantiate( enemyExplosion, transform.position, transform.rotation );
        }
      
        Destroy( gameObject );
    }
}
