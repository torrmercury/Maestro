using UnityEngine;
using System.Collections;

public class movingSelectTester : MonoBehaviour {
    int speed = 10;
    float moveChar = 0.0f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        moveChar = Input.GetAxis("Vertical") * speed;
        transform.position = new Vector3(0, moveChar, 0);
	}
}
