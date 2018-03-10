using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveCamera : MonoBehaviour {

	public float speed = 1.0f;
	public float maxSpeed = 20.0f;

	// Update is called once per frame
	void Update () {

		CharacterController controller = GetComponentInParent<CharacterController>();
		Vector3 forward = new Vector3 (0, 0, 0);
		if (Vector3.Angle (transform.forward, Vector3.forward) < 90) {
			forward = Camera.main.transform.forward;
		} else {
			forward = Vector3.forward;
		}

		if (speed < maxSpeed) {
			speed += Time.deltaTime/2.0f;
		}
		//controller.SimpleMove(Camera.main.transform.forward * speed);
		controller.SimpleMove(forward * speed);
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.collider.CompareTag("Death"))
			Respawn();
	}

	void Respawn(){
		transform.position = Vector3.zero;
	}

}
