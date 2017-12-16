﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory : ICharacterFactory {
	
    public override GameObject CreatePlayerObj( ENUM_Bullet _Em_Bullet, Vector3 _SpawnPosition ) {

        GameObject thePlayerObj = null;

        return thePlayerObj;
    }

    public override GameObject CreateEnemyObj( ENUM_Enemy _Em_Enemy, ENUM_Bullet _Em_Bullet, Vector3 _SpawnPosition ) {

        GameObject theEnemyObj = null;

        switch( _Em_Enemy ) {
            case ENUM_Enemy.Red:
                GameObject EnemyRedObj = Resources.Load( "EnemyRed", typeof(GameObject) ) as GameObject;
                GameObject.Instantiate( EnemyRedObj, _SpawnPosition, Quaternion.identity );
                EnemyRedObj = theEnemyObj;
                break;
        }

        return theEnemyObj;
    }

	public override IEnemy CreateEnemy( ENUM_Enemy _Em_Enemy, ENUM_Bullet _Em_Bullet, Vector3 _SpawnPosition ) {
		
		IEnemy theEnemy = null;

		switch( _Em_Enemy ) {
			case ENUM_Enemy.Red:

				GameObject EnemyRedObj = Resources.Load( "EnemyRed", typeof(GameObject) ) as GameObject;
                GameObject.Instantiate( EnemyRedObj, _SpawnPosition, Quaternion.identity );
				
				theEnemy = new EnemyRed( );

				GameSystem.Instance.AddEnemy( theEnemy );
			
				break;
		}
		
		return theEnemy;
		
	}

}
