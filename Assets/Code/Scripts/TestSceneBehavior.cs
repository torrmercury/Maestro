using UnityEngine;
using System.Collections;

public class TestSceneBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Escape) == true){
			Debug.Log("Player Pushed the Escape Key");
			Application.LoadLevel("TitleScreen");
		}
	
	}
}
