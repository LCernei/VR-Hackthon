using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour 
{

	void OnTriggerEnter(Collider other)
	{	//Debug.Log("colision "+ other.tag);
		
		if (other.CompareTag ("Player")) {
			SceneManager.LoadScene (0);
			//Application.LoadLevel(0);
		}

	}
		
}