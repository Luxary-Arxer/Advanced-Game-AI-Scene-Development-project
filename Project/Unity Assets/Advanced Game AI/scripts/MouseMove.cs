using UnityEngine;
using UnityEngine.AI;

public class MouseMove : MonoBehaviour {
	private NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (camRay, out hit, 100)) {
				agent.destination = hit.point;
			}
		}
	}
}
