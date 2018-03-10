using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Interaction : MonoBehaviour {
	public float interval;

	void Update () {
		
		RaycastHit hit = new RaycastHit ();
		Ray ray = new Ray ();
		ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 1.0f));

		if (Physics.Raycast (ray, out hit)) {

			if (hit.transform.name == "Cube") {
				if (interval > 0) {

					interval -= Time.deltaTime;
				} else {
					Application.LoadLevel (1);
				}
			} 

			if (hit.transform.name == "Capsule") {
				if (interval > 0) {
					interval -= Time.deltaTime;
				} else {
					Application.Quit ();
				}
			} 
		} else {
			interval = 1;
		}


	}		
}
