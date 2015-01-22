using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

	void OnTriggerEnter(Collider coll) {
		Debug.Log("Hit");
		if(coll.tag == "Player"){
			Application.LoadLevel("scene");
		}
	}
}
