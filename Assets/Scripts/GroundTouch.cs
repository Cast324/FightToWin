using UnityEngine;
using System.Collections;

public class GroundTouch : MonoBehaviour {
	public float groundSpeed;
	public float airSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		//Makes you move at a normal speed on ground
		AJUMPFORDEVITO.moveSpeed = groundSpeed;
	}
	void OnTriggerExit2D(Collider2D other) {
		//You become slower in the air, because you are in the air.
		AJUMPFORDEVITO.moveSpeed = airSpeed;
	}
}
