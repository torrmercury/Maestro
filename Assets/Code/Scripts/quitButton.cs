using UnityEngine;
using System.Collections;

public class quitButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseUpAsButton(){
		Debug.Log ("Player Clicked on the Quit Button");
		Application.Quit ();		
	}
	
}
