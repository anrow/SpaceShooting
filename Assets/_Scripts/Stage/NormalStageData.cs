using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalStageData : IStageData {

    private float m_CoolDownTime = 0;
    private float m_MaxCoolDownTime = 0;

    private Vector3 m_SpawnPosition = Vector3.zero;

    private bool m_IsAllEnemyBorn = false;

    private List<StageData> m_StageData = new List<StageData>( );

    class StageData {
       
    }

    public NormalStageData( float _CoolDownTime, Vector3 _SpawnPosition ) {
        m_MaxCoolDownTime = _CoolDownTime;
        m_CoolDownTime = m_MaxCoolDownTime;
        m_SpawnPosition = _SpawnPosition;
    }

    public override void Update( ) {
    }
    public override bool IsFinished( ) {
        return m_IsAllEnemyBorn;
    }
    public override void Reset( ){

        foreach( StageData FE_StageData in m_StageData ) {
            
        }

    }
}
