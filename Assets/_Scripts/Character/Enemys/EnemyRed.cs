using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyRed : IEnemy {

	private EnemyMove m_Movement = null;

	public GameObject InstanceRedObj;

	public override void Initinalize( ) {
		Debug.Log( "EnemyRedInit" );
		base.Initinalize( );
	}

}
