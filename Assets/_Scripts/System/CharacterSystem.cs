using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterSystem : GameSystem {

    public CharacterSystem( GameManager _GameManager ) :  base( _GameManager ) {
        
    }

    private List<ICharacter> m_Players = new List<ICharacter>( );

	private List<ICharacter> m_Enemys = new List<ICharacter>( );

    public void AddPlayer( IPlayer _Player  ) {
		m_Players.Add( _Player );
	}

	public void AddEnemy( IEnemy _Enemy  ) {
		m_Enemys.Add( _Enemy );
	}
    public void RemovePlayer( IPlayer _Player  ) {
		m_Players.Add( _Player );
	}

	public void RemoveEnemy( IEnemy _Enemy ) {
		m_Enemys.Remove( _Enemy );
	}

    public int GetEnemyCount( ) {
        return m_Enemys.Count;
    }

	public void RemoveCharacter( ) {

	}

	public void Removecharacter( List<ICharacter> _Characters, List<ICharacter> _Opponents ){
	}
		

	public override void Initinalize( ) {
	}

	public override void Update( ) {
      
	}

	public override void Release( ) {
	}

 }

