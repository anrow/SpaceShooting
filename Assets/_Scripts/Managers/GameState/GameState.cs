using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateManagement.GameState {
    public class GameState : MonoBehaviour {
        public enum EM_GameState {
            GAME_STATE_TITLE,
            GAME_STATE_PAUSE,
            GAME_STATE_PLAY,
            GAME_STATE_GAMEOVER
	    };

    private EM_GameState em_GameState = EM_GameState.GAME_STATE_TITLE;

    public EM_GameState gameState{ get{ return em_GameState; } }

    }
}
