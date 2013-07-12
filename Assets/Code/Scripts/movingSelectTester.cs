using UnityEngine;
using System.Collections;

public class movingSelectTester : MonoBehaviour {
//    int speed = 10;
//    float moveChar = 0.0f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //moveChar = Input.GetAxis("Vertical") * speed;
        //transform.position = new Vector3(0, moveChar * Time.deltaTime, 0);
		
		if (Input.GetKeyDown (KeyCode.UpArrow)){
			Debug.Log ("Up Arrow was Pressed");
			transform.position += new Vector3(0f, 10f, 0f);
			
		}else if (Input.GetKeyDown (KeyCode.DownArrow)){
			Debug.Log ("Down Arrow was Pressed");
			transform.position += new Vector3(0f, -10f, 0f);
			
		}
		
		if (Input.GetKeyDown (KeyCode.Space)){
			Debug.Log ("Space was Pressed");
			//transform.position += new Vector3(0f, 10f, 0f);
			
			
		}
		
		
		
	}
}
