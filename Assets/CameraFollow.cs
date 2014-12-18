using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform target;

	// Update is called once per frame
	void Update () {
        Vector3 ball = new Vector3(target.position.x, 7, target.position.z - 10);
        transform.position = ball;

	}
}
