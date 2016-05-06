using UnityEngine;
using System.Collections;

public class finish : MonoBehaviour {

	void OnCollisionStay(Collision coll){
	
		if (coll.gameObject.tag == "Finish") {

			this.gameObject.SetActive (false);
				
		}
	
	}
}
