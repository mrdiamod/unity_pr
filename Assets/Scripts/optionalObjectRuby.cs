using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class optionalObjectRuby : MonoBehaviour {
	private GameObject objRuby;// = new Object();
	public static int gridWidth = 10;
	public static int gridHeight = 10;
	public Object testObjects = new Object();
	public static  float beginPositionY = 100f;
	public string prefabObjectRuby = "Assets/Prefabs/ruby.prefab";

	public optionalObjectRuby(){
		testObjects = Instantiate (
							AssetDatabase.LoadAssetAtPath (
								prefabObjectRuby, 
								typeof(GameObject)
							), 
							new Vector3 (
								gameConstans._defaultPositionX, 
								beginPositionY, 
								gameConstans._defaultPositionZ
							), 
							Quaternion.identity
					  ) as GameObject;
	}
	

	//public optionalObjectRuby(){
//		for (int y=0; y<gridWidth; y++) {
//			for(int z=0; z<gridHeight;z++){
//				massivObjects[y,z] = Instantiate (AssetDatabase.LoadAssetAtPath ("Assets/Prefabs/ruby.prefab", typeof(GameObject)), new Vector3 (0.5f, y+positionObjectY,positionObjectZ - z), Quaternion.identity) as GameObject;
//			}
//		}	
//	}


}
