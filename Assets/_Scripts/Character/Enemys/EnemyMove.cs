using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    private Rigidbody m_Rb;

    public int a ; 
	// Use this for initialization
	void Start () {
        m_Rb = this.gameObject.GetComponent<Rigidbody>( );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
