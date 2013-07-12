using UnityEngine;
using System.Collections;

public class movingSelectTester : MonoBehaviour {
//    int speed = 10;
//    float moveChar = 0.0f;
	
	public Transform note;
	
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
			
			Instantiate(note, gameObject.transform.position + new Vector3(25f,0f,0f), Quaternion.identity);
			
			//note = new GameObject("T"); //prefab or set in workspace?
			//var meshFilter = gameObject.AddComponent<MeshFilter>();
			//gameObject.AddComponent<MeshRenderer>();
			//meshFilter.sharedMesh = objectToCreate;
			//note.transform.position = gameObject.transform.position + new Vector3(25f, 0f, 0f);
			//gameObject.transform.rotation = transform.rotation;
			
			
		}
		
		
		
	}
}
