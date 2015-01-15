using UnityEngine;
using System.Collections;

public class Pixel_Collectable : MonoBehaviour {

	void Update () {

		gameObject.transform.RotateAround(gameObject.transform.position, new Vector3(0,1,0), 10f);
	}

	void OnTriggerEnter(Collider coll) {
		if(coll.tag == "Player"){
			GameObject Score = coll.gameObject;
			Score.GetComponent<_GUI>().AddScore(100);
			Destroy(this.gameObject);
		}
	}
}