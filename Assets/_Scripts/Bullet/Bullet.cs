using UnityEngine;
using System.Collections;

public abstract class IBullet {

	protected ICharacter m_BulletOwner = null;

	public abstract void Shoot( );

	protected abstract void ShowBulletEffect ();

	protected abstract void PlaySound( string _ClipName );
}

public enum ENUM_Bullet {
    Red,
    Yellow,
    Blue,
    Green
}

