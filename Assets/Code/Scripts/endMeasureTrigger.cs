using UnityEngine;
using System.Collections;

public class endMeasureTrigger : MonoBehaviour {
	
	public Transform playerIcon;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider playerIcon){
			
		Debug.Log ("Collision");
		
		if (playerIcon.name == "Select Tester"){
			playerIcon.GetComponent<movingSelectTester>().resetLoop();
		}
		
	}
}
