using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
	
	public class GameStateTitle : State<GameState> {
		public override void EnterState( ) {
			Debug.Log ("Enter Title");
		}
		public override void UpdateState() {
			
		}
		public override void ExitState( ) {
			Debug.Log ("Exit Title");
		}
	}

	public class GameStatePause : State<GameState> {
		public override void EnterState( ) {
			Debug.Log ("Enter Pause");
		}
		public override void UpdateState() {
			
		}
		public override void ExitState( ) {
			Debug.Log ("Exit Pause");
		}
	}

	public class GameStatePlaying : State<GameState> {
		public override void EnterState( ) {
			Debug.Log ("Enter Playing");
		}
		public override void UpdateState() {
			
		}
		public override void ExitState( ) {
			Debug.Log ("Exit Playing");
		}
	}

	public class GameStateGameOver : State<GameState> {
		public override void EnterState( ) {
			Debug.Log ("Enter Over");
		}
		public override void UpdateState() {

		}
		public override void ExitState( ) {
			Debug.Log ("Exit Over");
		}
	}

	public class GameStateBase : State<GameState> {
		public override void EnterState( ) {
		}
		public override void UpdateState() {
		}
		public override void ExitState( ) {
		}
	}
}
