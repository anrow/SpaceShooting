using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UITool {

    private static GameObject m_CanvasObj = null;

    public static GameObject FindUIObject( string _UIName ) {
		
        if( m_CanvasObj == null ) {
			m_CanvasObj = UnityTool.FindObjInName( "Canvas" );
        }
		
		return UnityTool.FindChildObj( m_CanvasObj, _UIName );
        
    }

    public static T GetUIComponent<T>( GameObject _ContainerObj, string _UIName ) where T : UnityEngine.Component {
		
		GameObject ChildObj = UnityTool.FindChildObj( _ContainerObj, _UIName );
		
		if( ChildObj == null ) {
			return null;
		}
		
		T ComponentObj = ChildObj.GetComponent<T>( );
		
		if( ComponentObj == null ) {
			Debug.LogWarning( "Component" + _UIName + "is not" + typeof(T) );
			return null;
		}
		
		return ComponentObj;
    }
}
