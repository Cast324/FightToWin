using UnityEngine;
using System.Collections;

public class MoveDestination : MonoBehaviour {
	// Getting Target object , destination of that object, and the navmeshagent
	public Transform target;
	Vector3 destination;
	NavMeshAgent agent;
	
	void Start () {
		// Cache agent component and destination
		agent = GetComponent<NavMeshAgent>();
		destination = agent.destination;
	}
	
	void Update () {
		// Update destination if the target moves one unit
		if (Vector3.Distance (destination, target.position) > 1.0f) {
			destination = target.position;
			agent.destination = destination;
		}
	}

}
