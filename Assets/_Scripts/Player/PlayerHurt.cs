using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurt : MonoBehaviour {

    //プレーヤーの最大ライフポイント
    private const int DEFAULT_LIFE = 5;

    //プレーヤーのライフポイント
    private int life = DEFAULT_LIFE;

    public int Life( ) {
        return life;
    }

    public bool IsDead( ) {
        if( life == 0 ) {
            return true;
        }
        return false;
    }
	
    void OnCollisionEnter( Collision col ) {
       
    }
    
 }
