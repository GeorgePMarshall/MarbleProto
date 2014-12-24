using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float Player_Speed = 25f;
	public bool Grounded = false;

	void Update () {
		
		float X = Input.GetAxis ("Horizontal")*Player_Speed;
		float Z = Input.GetAxis ("Vertical")*Player_Speed;

		Vector3 fwd = Vector3.down;
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (Physics.Raycast (transform.position, fwd, .5f)) {
				rigidbody.velocity = new Vector3(rigidbody.velocity.x, 0, rigidbody.velocity.z);
				Debug.Log("Grounded true");
				Grounded = true;
			}
		}
		
		if (Grounded == true && (Input.GetKeyDown ("space"))){ //If the player is on the ground (True) and you press the Spacebar
			Grounded = false; 
			Vector3 Jump = new Vector3(0,10,0);
			rigidbody.AddForce(Jump * 60);
		}

		if (Grounded == false) {
			Physics.gravity = new Vector3(0,-1000 * Time.deltaTime,0);
		}


        Vector3 movement = new Vector3(X, 0, Z);
        rigidbody.AddForce(movement);
	}
}
/*
	void OnCollisionEnter(Collision collision) { //Check if the player is on the ground!
	
		if (collision.collider.gameObject.tag == "Ground") {
			Grounded = true;
			Debug.Log ("touching ground"); //Debug
		} else {
			Grounded = false;
		}
	}
}
using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {
	
	int layer = 1 << 8;
	
	// Update is called once per frame
	void Update () {
	
		Vector3 mouse = Input.mousePosition;

		//cast a ray from the screen into the world
		Ray ray = Camera.main.ScreenPointToRay (mouse);
		RaycastHit hitInfo;
		Physics.Raycast (ray, out hitInfo, 100 ,layer);

		// Adjiust target position's Y
		Vector3 target = hitInfo.point;
		target.y = transform.position.y;
		transform.LookAt (target);
	}
}

 * 
 */

