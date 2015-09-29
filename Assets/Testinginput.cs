using UnityEngine;
using System.Collections;

public class Testinginput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		UserInputs ();
	}

	void UserInputs() {
		if (Input.GetButtonDown ("360_AButton")) 
		{
			Debug.Log("A Button");
		}
		if (Input.GetAxisRaw ("360_RightVertical")) 
		{
			Debug.Log("A Button2");
		}

	}
}

