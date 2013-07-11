using UnityEngine;
using System.Collections;

public class startButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseUpAsButton(){
		Debug.Log ("Player Clicked on the Start Button");
		Application.LoadLevel("Test Scene");		
	}
	
}
