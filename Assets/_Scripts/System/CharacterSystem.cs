using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterSystem : GameSystem {

    public CharacterSystem( GameManager _GameManager ) :  base( _GameManager ) {
        Initinal( );
    }

    private Player m_Player = new Player( );

    private List<Character> m_Players = new List<Character>( );

	private List<Character> m_Enemys = new List<Character>( );

    public void AddPlayer( Player _Player  ) {
		m_Players.Add( _Player );
	}

	public void AddEnemy( Enemy _Enemy  ) {
		m_Enemys.Add( _Enemy );
	}
    public void RemovePlayer( Player _Player  ) {
		m_Players.Add( _Player );
	}

	public void RemoveEnemy( Enemy _Enemy ) {
		m_Enemys.Remove( _Enemy );
	}

    public int GetEnemyCount( ) {
        return m_Enemys.Count;
    }

	public void RemoveCharacter( ) {

	}

	public void Removecharacter( List<Character> _Characters, List<Character> _Opponents ){
	}
		

	public override void Initinal( ) {
        m_Player.Initinal( );
	}

	public override void Update( ) {
       
       m_Player.Update( );
	}

	public override void Release( ) {
	}

 }

