using UnityEngine;
using System.Collections;

public class gameConstans : MonoBehaviour {
	// Save this constaints

	//Constant default position X Y Z
	public static float _defaultPositionX = 0;
	public static float _defaultPositionY = 0;
	public static float _defaultPositionZ = 0;

	public static int _callDefaultPositionX=0;
	public static int _callDefaultPositionY=0;
	public static int _callDefaultPositionZ=0;


	//Константа пола, constant land
	public static float _contPositionLandY = -1f;

	// Constants games objects
	public  static float _scoreDefaultPositionY=0;
	public static float _steep = 1f;

	//Getters Setters
	public static float getScoreDefaultPositionY(){
		return _scoreDefaultPositionY;
	}

	public static float getAmountCallDefaultPositionY(){
		_callDefaultPositionY++;
		if (_callDefaultPositionY % 10 == 0)
						_scoreDefaultPositionY++;
		return _scoreDefaultPositionY;
	}


}
