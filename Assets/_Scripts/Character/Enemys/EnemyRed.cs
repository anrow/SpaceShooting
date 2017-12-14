using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : MonoBehaviour {

    private Rigidbody m_Rb;

    public int a;

    void Start( ) {
        m_Rb = this.gameObject.GetComponent<Rigidbody>( );
    }

}
