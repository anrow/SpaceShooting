using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StageSystem : GameSystem {

    public const int MAX_HEART = 5;

    private int m_NowHeart = MAX_HEART;

    private List<Vector3> m_SpawnPosition = null;

    public StageSystem( GameManager _GameManager ) : base( _GameManager ) {
    }

	public override void Initinalize( ) {
		//InitializeStageData( );
		GetSpawnPosition( );
	}
    public override void Update( ) {

	}
    public override void Release( ) {
	}

    private Vector3 GetSpawnPosition( ) {

		if( m_SpawnPosition == null ) {

			m_SpawnPosition = new List<Vector3>( );

			for( int i = 0; i <= 3; i++ ) {
               
				string spawnPosName = string.Format( "EnemySpawnPosition{0}", i );
				GameObject tempObj = UnityTool.FindObjInName( spawnPosName );


				/*if( tempObj == null ) {
					continue;
				}*/

				tempObj.SetActive( false );
				m_SpawnPosition.Add( tempObj.transform.position );

			}
        
		}
        int index = UnityEngine.Random.Range( 0, m_SpawnPosition.Count - 1 );
		Debug.Log( m_SpawnPosition.Count );
        return m_SpawnPosition[ index ];
    }

    private void InitializeStageData( ) {

        NormalStageData StageData = null;

        StageData = new NormalStageData( 1f, GetSpawnPosition( ) );
        StageData.AddStageData( ENUM_Enemy.Red, ENUM_Bullet.Red, 3 );
    }
}
