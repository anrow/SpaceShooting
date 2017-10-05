using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLabel : MonoBehaviour {

    public int score = 0;

    public int Score( ) {
        return score;
    }
    [SerializeField]
    private Text scoreLabel;

    public void UpdateScore( ) {
        scoreLabel.text = "Score : " + score.ToString( );
    }
    void Update( ) {
        
    }
}
