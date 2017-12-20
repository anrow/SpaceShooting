using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IStageController {
	
	protected IStageData m_StageData = null;

	protected IStageController m_NextStageController = null;

	protected IStageController SetNextStage( IStageController _NextStageController ) {
		m_NextStageController = _NextStageController;
		return m_NextStageController;
	}

	public abstract IStageController CheckStage( );
	public abstract void Update( );
	public abstract void Reset( );
	public abstract bool IsFinished( );
}
