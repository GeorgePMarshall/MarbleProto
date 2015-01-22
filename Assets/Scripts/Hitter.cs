using UnityEngine;
using System.Collections;

public class Hitter : MonoBehaviour {

	void Update () {

		gameObject.transform.Translate(new Vector3(0,0,-.3f));

		Destroy(this.gameObject, 2.5f);
	}

}
