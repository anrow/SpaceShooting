using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateManagement;

public class UIState : MonoBehaviour {

	public class UIStateTitle : State<UIState> {
		public override void EnterState( ) {
			Debug.Log ("Enter Title");
		}
		public override void UpdateState( ) {

		}
		public override void ExitState( ) {
			Debug.Log ("Exit Title");
		}
	}

	public class UIStatePause : State<UIState> {
		public override void EnterState( ) {
			Debug.Log ("Enter Pause");
		}
		public override void UpdateState( ) {

		}
		public override void ExitState( ) {
			Debug.Log ("Exit Pause");
		}
	}

	public class UIStatePlay : State<UIState> {
		public override void EnterState( ) {
			Debug.Log ("Enter Playing");
		}
		public override void UpdateState( ) {

		}
		public override void ExitState( ) {
			Debug.Log ("Exit Playing");
		}
	}

	public class UIStateGameOver : State<UIState> {
		public override void EnterState( ) {
			Debug.Log ("Enter Over");
		}
		public override void UpdateState( ) {

		}
		public override void ExitState( ) {
			Debug.Log ("Exit Over");
		}
	}

}
