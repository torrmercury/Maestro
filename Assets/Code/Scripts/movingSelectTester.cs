using UnityEngine;
using System.Collections;

public class movingSelectTester : MonoBehaviour {
//    int speed = 10;
//    float moveChar = 0.0f;
	
	public Transform note; //Assigned in inspector
	public Transform startpoint; //Assigned in inspector
	public Transform endpoint; //Assigned in inspector
	float startX;
	
	float tempo = 40; //tempo tells the testSelector how quickly it should move forward
	
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
		//Moves the testSelector back to the beginning of the bar staff once it hits the end
		/*
		 * This is currently buggy, a better solution would probably be to work with collision mechanics
		 * I'll look into that once I've gone thro ugh the documentation a bit 
		 * 
		   if (gameObject.transform.position.x == endpoint.position.x){
		
			transfrom.postion.x = startpoint.position.x; 
			
			}
		 */
		

		
		//Moves the testSelector at a constant rate forward
		transform.position += new Vector3(tempo *Time.deltaTime, 0f,0f);
		
	
		
		//Moves the testSelector up and down on key presses
		if (Input.GetKeyDown (KeyCode.UpArrow)){
			Debug.Log ("Up Arrow was Pressed");
			
			if(transform.position.y < 70f)
				transform.position += new Vector3(0f, 10f, 0f);
			
			Vector3 pos2 = transform.position;
			Debug.Log (pos2);
			
		}else if (Input.GetKeyDown (KeyCode.DownArrow)){
			Debug.Log ("Down Arrow was Pressed");
			
			if(transform.position.y >-70f)
				transform.position += new Vector3(0f, -10f, 0f);
			
			Vector3 pos = transform.position;
			Debug.Log (pos);
			
		}
		
		//Places a note in front of the testSelector when the spacebar is hit
		if (Input.GetKeyDown (KeyCode.Space)){
			Debug.Log ("Space was Pressed");
			
			GameObject oj;
			
			oj = Instantiate(note, gameObject.transform.position + new Vector3(25f,0f,0f), Quaternion.identity) as GameObject;
			oj.transform.parent = transform;
			
			
			//The rest of this junk down here is probably not needed, but keep it around for reference
			
			//note = new GameObject("T"); //prefab or set in workspace?
			//var meshFilter = gameObject.AddComponent<MeshFilter>();
			//gameObject.AddComponent<MeshRenderer>();
			//meshFilter.sharedMesh = objectToCreate;
			//note.transform.position = gameObject.transform.position + new Vector3(25f, 0f, 0f);
			//gameObject.transform.rotation = transform.rotation;
			
			
		}
		
<<<<<<< HEAD
		if (Input.GetKeyDown(KeyCode.L)){
			Debug.Log ("L pressed");
			resetLoop ();	
		}
		
=======
		if (transform.position.x >= 250f){
			transform.position = new Vector3(0f, transform.position.y, 100f);
			
			
>>>>>>> Changed minor stuff
		
		}
		
	}
	
	public void resetLoop(){
		Debug.Log("resetLoop Called");
		float startX = startpoint.position.x;
		transform.position = new Vector3(startX, transform.position.y,transform.position.z);	
//		transform.position = new Vector3(0f,-20f,0f);
	}
}
