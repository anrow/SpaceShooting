using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePanel : MonoBehaviour {
    [SerializeField]
    private GameObject[ ] lifeIcons;

	public void UpdateLife( int life ) {
        for( int i = 0; i < lifeIcons.Length; i++ ) {
            if( i < life ) {
                lifeIcons[ i ].SetActive( true );
            } else {
                lifeIcons[ i ].SetActive( false );
            }
        }
    }
}
