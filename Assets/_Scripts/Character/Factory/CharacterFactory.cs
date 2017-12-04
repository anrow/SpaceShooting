using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory : ICharacterFactory {

	private CharacterSystem m_CharacterSystem = new CharacterSystem( GameManager.Instance ); 

    public override IPlayer CreatePlayer( ENUM_Bullet _Em_Bullet, Vector3 _SpawnPosition ) {

        IPlayer thePlayer = null;

        return thePlayer;
    }

    public override IEnemy CreateEnemy( ENUM_Enemy _Em_Enemy, ENUM_Bullet _Em_Bullet, Vector3 _SpawnPosition ) {

        IEnemy theEnemy = null;

        switch( _Em_Enemy ) {
			case ENUM_Enemy.Red:
				theEnemy = new IEnemyRed( );               
                break;
        }

		m_CharacterSystem.AddEnemy (theEnemy);

		Debug.Log (theEnemy);

        return theEnemy;
    }
}
