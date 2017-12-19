using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ICharacter {

	protected string m_Name = "";

	protected GameObject m_GameObject = null;

	protected Rigidbody m_Rigidbody = null;

	protected Transform m_ShootTrans = null;

	protected bool m_isKilled = false;

	protected bool m_isCheckKilled = false;

	protected bool m_canRemove = false;

	protected float m_RemoveTimer = 1.0f;

    protected float speed = 10f;

	private IBullet m_Bullet = null;

	public ICharacter( ) { }

	protected void BulletShoot( ) {
		m_Bullet.Shoot( );
	}

	public abstract void Attack( ICharacter _AttackTarget ); 

	public abstract void UnderAttack( ICharacter _Attacker );

	public virtual void SetGameObject( GameObject _GameObject ) {
		
		m_GameObject = _GameObject;

		m_Rigidbody = m_GameObject.GetComponent<Rigidbody>( );

		m_ShootTrans = m_GameObject.GetComponentInChildren<Transform>( );

	}

    public virtual void Movement( Rigidbody _Rigidbody, float _Tilt ) { }
    public virtual void Movement( ENUM_Enemy _EnemyType, float _Tilt ) { }
    public abstract void Initinalize( );

    public abstract void Update( );

	public void Release( ) {

		if( m_GameObject != null ) {

			GameObject.Destroy( m_GameObject );

		}
	}
}
   
