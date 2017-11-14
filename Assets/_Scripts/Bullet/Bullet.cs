using UnityEngine;
using System.Collections;

public abstract class Bullet {

	protected Character m_BulletOwner = null;

	public abstract void Shoot( );

	protected abstract void ShowBulletEffect ();

	protected abstract void PlaySound( string _ClipName );
}

