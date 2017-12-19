using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterSystem : IGameSystem {

    private List<ICharacter> m_Players = new List<ICharacter>( );

	private List<ICharacter> m_Enemys = new List<ICharacter>( );

    public CharacterSystem( GameSystem _GameSystem ) : base( _GameSystem ) {
        Initinalize( );
    }

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
		UpdateCharacter( );
	}

	public override void Release( ) {
	}


	private void UpdateCharacter( ) {
		foreach( ICharacter _Character in m_Players ) {
			_Character.Update( );
		}
		foreach( ICharacter _Character in m_Enemys ) {
			Debug.Log( m_Enemys );
			_Character.Update( );
		}
      
	}
 }

