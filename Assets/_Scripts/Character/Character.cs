using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour {

	protected string m_Name = "";

	protected GameObject m_GameObject = null;

	protected Rigidbody m_Rigidbody = null;

	protected Transform m_ShootTrans = null;

	protected bool m_isKilled = false;

	protected bool m_isCheckKilled = false;

	protected bool m_canRemove = false;

	protected float m_RemoveTimer = 1.0f;

    protected float speed = 10f;

	private Bullet m_Bullet = null;

	public Character( ) { }

	protected void BulletShoot( ) {
		m_Bullet.Shoot( );
	}

	public abstract void Attack( Character _AttackTarget ); 

	public abstract void UnderAttack( Character _Attacker );

	public void SetGameObject( GameObject _GameObject ) {
		
		m_GameObject = _GameObject;

		m_Rigidbody = m_GameObject.GetComponent<Rigidbody>( );

		m_ShootTrans = m_GameObject.GetComponentInChildren<Transform>( );

	}

    public abstract void Movement( Rigidbody _Rigidbody, float tilt );

	public void Release( ) {

		if( m_GameObject != null ) {
			GameObject.Destroy( m_GameObject );
		}
	}
}
   
