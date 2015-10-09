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

	//Find total vertical speed
	public float totalVerticalSpeed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("360_AButton")) {
			NumberofJumps = NumberofJumps + 1; 
		}

		//Can't jump if you have already jumped twice. I mean, it's already kind of impressive that a person can jump while in the air.
		if (NumberofJumps > 1.9) {
			AJUMPFORDEVITO.jumpHeight = 0f;
		}

		//Find Vertical Speed
		totalVerticalSpeed = GetComponentInParent<Rigidbody2D>().velocity.y;


	}

	void OnTriggerEnter2D(Collider2D other) {

	}

	void OnTriggerStay2D(Collider2D other){

		// If you have stopped moving vertically because you landed, set jumps back to zero
		if (totalVerticalSpeed == 0) {
			NumberofJumps = 0;
			//Set Jumpheight for being on the ground
			AJUMPFORDEVITO.jumpHeight = groundjumpHeight;
		}


		//Makes you move at a normal speed on ground
		AJUMPFORDEVITO.moveSpeed = groundSpeed;

	}

	void OnTriggerExit2D(Collider2D other) {
		//You become slower in the air, because you are in the air.
		AJUMPFORDEVITO.moveSpeed = airSpeed;

		//If jumping in air, set the jump height to double jump height.
		if (NumberofJumps < 2) {
			AJUMPFORDEVITO.jumpHeight = doublejumpHeight;
		}

	}
}
