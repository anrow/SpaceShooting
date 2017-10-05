using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    [SerializeField]
    private GameObject[ ] enemys;

    [SerializeField]
    private Vector3 enemyVaule;

    //次の敵出てくる時間
    [SerializeField]
    private float creatTime;
    [SerializeField]
    private float originalTime;

  
	// Use this for initialization
	void Start( ) {
		originalTime = creatTime;
	}
    

	// Update is called once per frame
	void FixedUpdate () {
		EnemySpwan( );
	}

    void EnemySpwan( ) {
        GameObject enemy = enemys[ Random.Range( 0, enemys.Length ) ];
        creatTime -= Time.deltaTime;
        if( creatTime <= 0 ) {
            Vector3 enemyPosition = new Vector3( Random.Range( -enemyVaule.x, enemyVaule.x ), 
                                                 enemyVaule.y, 
                                                 enemyVaule.z );

            Quaternion enemyRotation = new Quaternion( 0, 180, 0, 0 );

            Instantiate( enemy, enemyPosition, enemyRotation );
            creatTime = originalTime;
        }
    }

}
