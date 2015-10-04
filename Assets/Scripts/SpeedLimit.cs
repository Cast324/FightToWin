using UnityEngine;
using System.Collections;

public class SpeedLimit : MonoBehaviour {

	public float totalHorizontalSpeed;
	public float totalVerticalSpeed;
	public float HorizontalLimit;
	public float negativeHorizontalLimit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		totalHorizontalSpeed = GetComponent<Rigidbody2D>().velocity.x;
		totalVerticalSpeed = GetComponent<Rigidbody2D>().velocity.y;

		if (totalHorizontalSpeed > HorizontalLimit) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.left * (totalHorizontalSpeed - HorizontalLimit) * 3);
		}
		else if (negativeHorizontalLimit > totalHorizontalSpeed) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.left * (totalHorizontalSpeed - negativeHorizontalLimit)* 3);
		}
	}
}
