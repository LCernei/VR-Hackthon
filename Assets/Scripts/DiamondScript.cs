using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour {
	[SerializeField]
	private GameObject controller;

	void Update () {
		transform.Rotate (Vector3.up, 100.0f * Time.deltaTime);
	}

	// Receive points from stars
	void OnTriggerEnter(Collider other)
	{	
		if (other.CompareTag ("Player")) {
			GameObject sm =  GameObject.Find ("ScoreManager");
			ScoreManager smScript = sm.GetComponent<ScoreManager> ();
			smScript.scoreCount += 10;
			Destroy (gameObject);
		}

	}
}
