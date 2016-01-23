using UnityEngine;
using System.Collections;

public class PlayerAiming : MonoBehaviour  {
	// Update is called once per frame
	void Update ()
	{
		// We are going to read the input every frame
		Vector3 vNewInput = new Vector3(Input.GetAxis("360_RightHorizontal"), Input.GetAxis("360_RightVertical"), 0.0f);
		
		// Only do work if meaningful
		if(vNewInput.sqrMagnitude < 0.1f)
		{
			return;
		}
		
		// Apply the transform to the object  
		var angle = Mathf.Atan2(Input.GetAxis("360_RightHorizontal"), Input.GetAxis("360_RightVertical")) * Mathf.Rad2Deg - 90;
		transform.rotation = Quaternion.Euler(0 , 0 , angle);
	}
}