using UnityEngine;
using System.Collections;

public class Pixel_Collectable : MonoBehaviour {

	void Update () {
		gameObject.transform.RotateAround(gameObject.transform.position, new Vector3(0,1,0), 1f);
	}

	void OnTriggerEnter(Collider coll) {
		Destroy(this.gameObject);
	}
}