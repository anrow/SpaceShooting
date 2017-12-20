using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalStageData : IStageData {

	private ObjectFactory m_Factory = new ObjectFactory( );

    private float m_CoolDownTime = 0;
    private float m_MaxCoolDownTime = 0;

    private Vector3 m_SpawnPosition = Vector3.zero;

    private bool m_IsAllEnemyBorn = false;

    private List<StageData> m_StageData = new List<StageData>( );

    class StageData {
		
        public ENUM_Enemy emEnemy = ENUM_Enemy.Red;
		public ENUM_Bullet emBullet = ENUM_Bullet.Null;
		public bool isBorn = false;

		public StageData( ENUM_Enemy _Em_Enemy, ENUM_Bullet _Em_Bullet ) {
			this.emEnemy = _Em_Enemy;
			this.emBullet = _Em_Bullet;
        }
    }

    public NormalStageData( float _CoolDownTime, Vector3 _SpawnPosition ) {
        m_MaxCoolDownTime = _CoolDownTime;
        m_CoolDownTime = m_MaxCoolDownTime;
        m_SpawnPosition = _SpawnPosition;
    }

	public void AddStageData( ENUM_Enemy _Em_Enemy, ENUM_Bullet _Em_Bullet, int _Count ) {
		for( int i = 0; i < _Count; ++i ) {
			m_StageData.Add( new StageData( _Em_Enemy, _Em_Bullet ) );
		}
	}

    public override void Update( ) {
		/*if( m_StageData.Count == 0 ) {
			return;
		}

		m_CoolDownTime -= Time.deltaTime;

		if( m_CoolDownTime > 0 ) {
			return;
		}

		m_CoolDownTime = m_MaxCoolDownTime;

		StageData theNewEnemy = GetEnemy( );
	
		if( theNewEnemy == null ) {
			return;
		}*/

		//m_Factory.CreateEnemyObj( theNewEnemy.emEnemy, theNewEnemy.emBullet, m_SpawnPosition );
		m_Factory.CreateEnemyObj( ENUM_Enemy.Red, ENUM_Bullet.Red, m_SpawnPosition );
    }
    public override bool IsFinished( ) {
        return m_IsAllEnemyBorn;
    }
    public override void Reset( ){

        foreach( StageData FE_StageData in m_StageData ) {
            
        }

    }

	private StageData GetEnemy( ) {
		foreach( StageData FE_StageData in m_StageData ) {
			if( FE_StageData.isBorn == false ) {
				FE_StageData.isBorn = true;
				return FE_StageData;
			}
		}
		m_IsAllEnemyBorn = true;
		return null;
	}
}
