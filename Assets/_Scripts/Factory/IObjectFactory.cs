using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IObjectFactory {

    public abstract GameObject CreatePlayerObj( ENUM_Bullet _Em_Bullet, Vector3 _SpawnPosition );

    public abstract GameObject CreateEnemyObj( ENUM_Enemy _Em_Enemy, ENUM_Bullet _Em_Bullet, Vector3 _SpawnPosition );

}
