using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WaterRespawn : MonoBehaviour {
	
	// Update is called once per frame
	void FixedUpdate(){

		if(gameObject.GetComponent<Rigidbody>().position.y < 17)
		{

			SceneManager.LoadScene (SceneManager.GetActiveScene().name);

		}
	
	}
}
