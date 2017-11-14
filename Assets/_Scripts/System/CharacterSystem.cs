using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterSystem : GameSystem {

	public CharacterSystem( GameManager _GameManager ) : base( _GameManager ) {
		
	}

	private List<Character> m_Enemys = new List<Character>( );

	public void AddEnemy( Enemy _Enemy  ) {
		m_Enemys.Add( _Enemy );
	}

	public void RemoveEnemy( Enemy _Enemy ) {
		m_Enemys.Remove( _Enemy );
	}

	public void RemoveCharacter( ) {

	}

	public void Removecharacter( List<Character> _Characters, List<Character> _Opponents ){
	}
		

	public override void Initinal( ) {
		
	}

	public override void Update( ) {
	}

	public override void Release( ) {
	}

 }

