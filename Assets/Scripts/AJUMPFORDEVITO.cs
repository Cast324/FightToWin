using UnityEngine;
using System.Collections;

public class AJUMPFORDEVITO : MonoBehaviour {

	//Used to determine how high the character can jump in air and on land.
	public static float jumpHeight;

	//Set the overall jump height
	public float jumpPower;

	//Set the total jump height
	public float jumpValue = 1.0f;

	// Used to determine how fast to move in air and on land
	public static float moveSpeed = 0f;

	// Used to set overall speed
	public float speed = .9f;

	// Final Speed Value
	public float moveValue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		UserInputs ();

		//Calculates the final speed.
		moveValue = Input.GetAxis("360_LeftHorizontal") * moveSpeed * speed;

		//Calculates the final jump height.
		jumpValue = jumpHeight * jumpPower;

	}
	void UserInputs() {

		// If Button A is Hit, then jump.
		if (Input.GetButtonDown ("360_AButton")) {
			Debug.Log("Pls Jump");
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpValue);
		}

		// If Left Joystick is being used, then change the move speed.
		if(Input.GetAxis("360_LeftHorizontal") != 0) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.right * moveValue);

		}
	}
}