using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameState : SceneState {

    public MainGameState( SceneStateController Controller ) : base( Controller ) {
        this.StateName = "MainGame";
    }

}
