using UnityEngine;
using System.Collections;

public class HitZone : MonoBehaviour {

	public bool punchIt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		UserInputs ();

		
	}
	void OnTriggerStay2D(Collider2D other){

		if (other.tag == "MoveableObject") {
			Debug.Log ("INTHEPUNCHZONE");
			if (punchIt == true){
			other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 2000);
				Debug.Log ("WEW");
			}
			}
	}
	
	void OnTriggerExit2D(Collider2D other){

	}
	void UserInputs(){
		punchIt = Input.GetButton ("360_BButton");
	}

	}


