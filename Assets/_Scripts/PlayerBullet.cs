using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

    private Rigidbody rb;

    [SerializeField]
    private float speed;

	// Use this for initialization
	void Start( ) {
		rb = this.gameObject.GetComponent<Rigidbody>( );
	}

    void FixedUpdate( ) {
        rb.velocity = Vector3.forward * speed;
    }

    // Update is called once per frame
    void Update( ) {
		
	}
}
