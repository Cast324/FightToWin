using UnityEngine;
using System.Collections;

public class GroundTouch : MonoBehaviour {
	//Set speed on ground
	public float groundSpeed;

	//Set speed in the air
	public float airSpeed;

	//Set jump height in air
	public float doublejumpHeight;

	//Find amount of times jumped
	public float NumberofJumps;

	//Set jump height on ground
	public float groundjumpHeight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("360_AButton")) {
			
			NumberofJumps = NumberofJumps + 1; 

		}
		//Can't jump if you have already jumped twice. I mean, it's already kind of impressive that a person can jump while in the air.
		if (NumberofJumps == 2) {
			AJUMPFORDEVITO.jumpHeight = 0f;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		//Makes you move at a normal speed on ground
		AJUMPFORDEVITO.moveSpeed = groundSpeed;

		//Set Jumpheight for being on the ground
		AJUMPFORDEVITO.jumpHeight = groundjumpHeight;

		//When you land, reset the number of jumps
		NumberofJumps = 0;
	}
	void OnTriggerExit2D(Collider2D other) {
		//You become slower in the air, because you are in the air.
		AJUMPFORDEVITO.moveSpeed = airSpeed;

		//If double jumping, set the jump height to double jump height.
		if (NumberofJumps < 2) {
			AJUMPFORDEVITO.jumpHeight = doublejumpHeight;
		}

	}
}
