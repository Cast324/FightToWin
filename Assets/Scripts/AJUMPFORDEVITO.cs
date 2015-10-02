using UnityEngine;
using System.Collections;

public class AJUMPFORDEVITO : MonoBehaviour {
	public float jumpHeight;
	public static float moveSpeed = 0f;
	public static float speed = .9f;
	public float moveValue;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		UserInputs ();
		moveValue = Input.GetAxis("360_LeftHorizontal") * moveSpeed * speed;	
	}
	void UserInputs() {
		if (Input.GetButtonDown ("360_AButton")) {
			Debug.Log("Pls Jump");
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight);
	}
	
		if(Input.GetAxis("360_LeftHorizontal") != 0) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.right * moveValue);

		}
	}
}