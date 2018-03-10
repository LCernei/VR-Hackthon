using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Jump : MonoBehaviour {

	public FirstPersonController controller;

	// Use this for initialization
	void Start () {
		controller = GetComponentInParent<FirstPersonController> ();
	}

	// Update is called once per frame
	void Update () {

		RaycastHit hit = new RaycastHit ();
		Ray ray = new Ray ();
		ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 1.0f));

		if (Physics.Raycast (ray, out hit)) {
			if (hit.transform.name == "JCube") {
				controller.onJump ();
			}

		}

	}
}
