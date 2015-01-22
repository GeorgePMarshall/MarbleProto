using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public float timer = 10;
	public GameObject bumber;
	
	void Update () {
		timer -= .1f;
		if(timer <= 0){
			GameObject obj = Instantiate (bumber, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			timer = 10;
		}
	}
	
}
