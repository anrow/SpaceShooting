using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnityTool {

    public static GameObject FindObjInName( string _ObjName ) {

        GameObject obj = GameObject.Find( _ObjName );

        if( obj == null ) {
			return null;
        }
		
		return obj;

    }
	
	public static GameObject FindObjInTag( string _ObjTag ) {
		
		GameObject obj = GameObject.FindGameObjectWithTag( _ObjTag );
		
		if( obj == null ) {
			return null;
		}
		
		return obj;
		
	}
	
	public static GameObject FindChildObj( GameObject _ContainerObj, string _ObjName ) {
		
		if( _ContainerObj == null ) {
			return null;
		}
		
		Transform ObjTrans = null;
		
		if( _ContainerObj.name == _ObjName ){
			ObjTrans = _ContainerObj.transform;
		}
		else {
			
			Transform[ ] AllChildrenTrans = _ContainerObj.transform.GetComponentsInChildren<Transform>( );
			
			foreach( Transform _ChildTrans in AllChildrenTrans ) {
				
				if( _ChildTrans.name == _ObjName ) {
					
					if( ObjTrans == null ) {
						
						ObjTrans = _ChildTrans;
					}
				}
			}
		}
		
		if( ObjTrans == null ) {
			Debug.LogError( _ContainerObj.name + "can not find child component" + _ObjName );
			return null;
		}
		return ObjTrans.gameObject;
	}
}
