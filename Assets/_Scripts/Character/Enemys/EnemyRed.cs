﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : MonoBehaviour {
	
	private IEnemy m_Enemy = new IEnemy( );

    void Start( ) {
        m_Enemy.SetGameObject( this.gameObject );
        Debug.Log( "red" );
    }
}
