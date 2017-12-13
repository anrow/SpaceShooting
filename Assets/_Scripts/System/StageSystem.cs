using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StageSystem : IGameSystem {

    public const int MAX_HEART = 5;

    private int m_NowHeart = MAX_HEART;

    private List<Vector3> m_SpawnPosition = null;

    public StageSystem( GameSystem _GameSystem ) : base( _GameSystem ) {
        Initinalize( );
    }

	public override void Initinalize( ) {
        InitializeStageData( );
	}
    public override void Update( ) {
        
	}
    public override void Release( ) {
	}

    private Vector3 GetSpawnPosition( ) {

		if (m_SpawnPosition == null) {

			m_SpawnPosition = new List<Vector3> ();

			for (int i = 0; i <= 3; ++i) {
               
				string spawnPosName = string.Format ("EnemySpawnPosition{0}", i);
				GameObject tempObj = UnityTool.FindObjInName (spawnPosName);
				Debug.Log (spawnPosName);

				if (tempObj == null) {
					continue;
				}

				tempObj.SetActive (false);
				m_SpawnPosition.Add (tempObj.transform.position);

			}
        
		}
        int index = UnityEngine.Random.Range( 0, m_SpawnPosition.Count );
	
        return m_SpawnPosition[ index ];
    }

    private void InitializeStageData( ) {

        NormalStageData EnemyStageData = null;

        EnemyStageData = new NormalStageData( 3f, GetSpawnPosition( ) );
    }
}
