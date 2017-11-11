using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameState : SceneState {

    public MainGameState( SceneStateController _Controller ) : base( _Controller ) {
        this.StateName = "MainGame";
    }

}
