using UnityEngine;
using System.Collections;

public class physicsMaterials : MonoBehaviour {

	public static float time = 0;
	public static float g = 9.8f;
	public static float hn = 0;
	public static float newPositionObjectY;
	public static float positionObjectY;
	//public static int u = 0;
	public static float u;
	public static float t1,h1,p1;
	// Use this for initialization
	void Start () {
		positionObjectY = GetComponent<Transform> ().transform.position.y;
		//time = Time.deltaTime;
		t1 = Mathf.Sqrt((2f * 100f) / g);
		Debug.Log("Нужное время -> " + t1);
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		hn = (g * time*time ) / 2;						
		newPositionObjectY = positionObjectY - hn;
						 
		if ( newPositionObjectY  >= gameConstans.getScoreDefaultPositionY()) {
			transformLocalPositionForY();
		} else
			if(newPositionObjectY  != gameConstans.getScoreDefaultPositionY()){
				lastCorrectionPosition ();
				transformLocalPositionForY();
			}
	}

	public void lastCorrectionPosition(){
		float correctionPosition;
		if(newPositionObjectY != gameConstans.getScoreDefaultPositionY()){
			correctionPosition = newPositionObjectY - gameConstans.getScoreDefaultPositionY();
			newPositionObjectY -=correctionPosition;
		}
	}

	public void transformLocalPositionForY(){
		GetComponent<Transform> ().transform.localPosition = new Vector3 (
																GetComponent<Transform> ().transform.position.x,
																newPositionObjectY, 
																GetComponent<Transform> ().transform.position.z
															);
	}
}
