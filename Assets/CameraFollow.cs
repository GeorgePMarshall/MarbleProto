using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float speed;
	public float radius;
	public float offset;
	
	Vector3 direction;
	
	// Update is called once per frame
	void Update () {
		direction = target.position - transform.position + transform.up * offset;
		direction.y = 0;
		float distance = direction.magnitude;
		direction.Normalize();
		
		if (distance > radius)
			transform.position = transform.position + direction * speed * Time.deltaTime;
	}
}
