using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodController : MonoBehaviour {

    [SerializeField]
    private float tumbleRadius;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float speed;

    [SerializeField]
    private GameObject asteriodExplosion;

    [SerializeField]
    private ScoreLabel scoreLabel;

	// Use this for initialization
	void Start( ) {
		rb = gameObject.GetComponent<Rigidbody>( );

        //角速度
        //半径（tumbleRadius） の球体の内部のランダムな点を返す
        rb.angularVelocity = Random.insideUnitSphere * tumbleRadius;
	}
	
	// Update is called once per frame
	void Update( ) {
		rb.velocity = -Vector3.forward * speed;
	}
    void OnTriggerEnter( Collider other ) {
        if ( other.tag == "Player" || other.tag == "Bullet" ) {
            Instantiate( asteriodExplosion, transform.position, transform.rotation );
        }
        if( other.tag == "Bullet" ) {
            scoreLabel.score += 10;
        }
     
        Destroy( gameObject );
        
    }
   
}
