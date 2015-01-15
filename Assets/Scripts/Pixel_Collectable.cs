using UnityEngine;
using System.Collections;

public class Pixel_Collectable : MonoBehaviour {

	float y;
	float yup;

	void Start(){
		y = gameObject.transform.position.y;
	}

	void Update () {
		yup = gameObject.transform.position.y;
		gameObject.transform.RotateAround(gameObject.transform.position, new Vector3(0,1,0), 1f);

		if(yup <= y+.5f){
			Debug.Log("Over " + y);
			gameObject.transform.Translate(new Vector3(0,0,.01f));
		}else if(yup >= y + -.5f){
			Debug.Log("Under " + y);
			gameObject.transform.Translate(new Vector3(0,0,-.01f));
		}
	}
}
