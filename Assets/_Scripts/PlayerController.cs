using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour {

    [SerializeField]
    private Rigidbody rb;

    //プレーヤーの移動速度
    [SerializeField]
    private float speed;

    //回転係数 tilt//
    [SerializeField]
    private float tilt;

    private float axisX = 0;
    private float axisZ = 0;
    private bool isMoveX = false;
    private bool isMoveZ = false;
    private bool isShoot = false;
    
    //弾丸のオブジェクト
    [SerializeField]
    private GameObject bullet;

    //生成した弾丸のトランスフォーマー
    [SerializeField]
    private Transform shotTrans;

    //弾丸が生成する時間
    private float nextBulletTime;

    //弾丸の生成速度率
    [SerializeField]
    private const float bulletRate = 0.25f;

    //プレーヤー爆発の効果prefab
    [SerializeField]
    private GameObject playerExplosion;

    //プレーヤーの最大ライフポイント
    private const int DEFAULT_LIFE = 5;

    //プレーヤーのライフポイント
    private int life = DEFAULT_LIFE;

    //ライフの読み込み
    public int Life( ) {
        return life;
    }
    //プレーヤーの気絶判定
    private bool IsDead( ) {
        if( life == 0 ) {
            return true;
        }
        return false;
    }
  
	void Awake( ) {
        rb = gameObject.GetComponent<Rigidbody>( );
        shotTrans = GameObject.FindGameObjectWithTag( "PlayerShotTrans" ).transform;
	}
    void FixedUpdate( ) {

        axisX = Input.GetAxis( "Horizontal" );
        axisZ = Input.GetAxis( "Vertical" );

        HandleMovement( );
        HandleInput( );
       
        Boundary.Instance.LimitBoundary( rb );
    }
    void Update( ){
     
    }
    //移動の計算
    void HandleMovement( ) {
        //X軸の移動
        if( isMoveX ) {
            rb.velocity = new Vector3( axisX * speed, 0, rb.velocity.z );

            //Z方向の回転//
            rb.rotation = Quaternion.Euler( rb.rotation.x, 0, axisX * -tilt );
        }  
        //Z軸の移動
        if( isMoveZ ) {
             rb.velocity = new Vector3( rb.velocity.x, 0, axisZ * speed );
        }
      
        //シューティング
        if( isShoot ) {
             //次の弾丸の時間計算
            nextBulletTime = Time.time + bulletRate;

            //弾丸のクローン
            Instantiate( bullet, shotTrans.position, shotTrans.rotation );
            
            isShoot = false;
        }
    }

    //コントロールの入力（Input）
    void HandleInput( ) {
        if( axisX != 0 ) {
            isMoveX = true;
        }
        if( axisZ != 0 ) {
            isMoveZ = true;
        }
     
        if( Input.GetButton( "Fire1" ) && Time.time > nextBulletTime ) {
           isShoot = true;
           
        }
    }

    void OnTriggerEnter( Collider other ) {

        life--;

        if( IsDead( ) ) {
            Instantiate( playerExplosion, transform.position, transform.rotation );
            Destroy( gameObject );
            ReturnToTitle( );
        }
        
    }

    void ReturnToTitle( ) {
        SceneManager.LoadScene( "Title" );
    }

}
