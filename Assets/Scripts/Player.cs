using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float Player_Speed = 25f;
	public float Player_Jump = 60f;

	void Update () {
		
		float X = Input.GetAxis ("Horizontal")*Player_Speed;
		float Z = Input.GetAxis ("Vertical")*Player_Speed;

		Vector3 fwd = Vector3.down;
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (Physics.Raycast (transform.position, fwd, .7f)) {
				rigidbody.velocity = new Vector3(rigidbody.velocity.x, 0, rigidbody.velocity.z);
				Vector3 Jump = new Vector3(0,10,0);
				rigidbody.AddForce(Jump * Player_Jump);
			}
		}

		if(!Physics.Raycast(transform.position, fwd, .5f)){
			Physics.gravity = new Vector3 (0, -1000 * Time.deltaTime, 0);
			Player_Speed = 12;
		}else{
			Player_Speed = 20f;
		}


        Vector3 movement = new Vector3(X, 0, Z);
        rigidbody.AddForce(movement); //addforce


	}
}