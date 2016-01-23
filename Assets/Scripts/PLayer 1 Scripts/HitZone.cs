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
		var angle = Mathf.Atan2(Input.GetAxis("360_RightHorizontal"), Input.GetAxis("360_RightVertical")) * Mathf.Rad2Deg - 90;

		if (other.tag == "MoveableObject") {
			Debug.Log ("INTHEPUNCHZONE");
			if (punchIt == true){
				Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector2.right;
				other.GetComponent<Rigidbody2D>().AddForce(dir * 2000);
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


