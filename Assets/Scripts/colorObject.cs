using UnityEngine;
using System.Collections;

public class colorObject : MonoBehaviour {
	private ArrayList colorsMaterials = new ArrayList() {Color.black, Color.red, Color.yellow, Color.green, Color.blue};

	private Color getColor (){
		return (Color)colorsMaterials[Random.Range(0,colorsMaterials.Count-1)];
	}

	// Use this for initialization
	void Start () {
		//GetComponent<MeshRenderer> ().material.color = getColor ();
		GetComponent<MeshRenderer> ().material.color = getColor ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
