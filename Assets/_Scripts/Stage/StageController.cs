using UnityEngine;
using System.Collections;

public class StageController : IStageController{

	public StageController( IStageData _StageData ) {
		m_StageData = _StageData;
	}

	public override IStageController CheckStage( ) {

		if( m_NextStageController == null ) {
			return this;
		}

		return m_NextStageController.CheckStage( );
	}

	public override void Update( ){
		m_StageData.Update( );
	}

	public override void Reset( ) {
		m_StageData.Reset( );
	}

	public override bool IsFinished( ) {
		return m_StageData.IsFinished( );
	}
}

