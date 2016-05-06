using UnityEngine;
using System.Collections;

public class WallRun : MonoBehaviour {
	
	void OnCollisionStay(Collision wall) {

		if(wall.gameObject.tag == "Wall" && Input.GetKey("e") && !gameObject.isStatic)
		{
			this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
		}
		this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

	}
		
}
