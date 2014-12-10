using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float Player_Speed = 10f;
	public float Jump_Force = 30f;
	public float Gravity = 10f;
	public bool Grounded = false;
	

	void Update () {
		
		float X = Input.GetAxis ("Horizontal");
		float Z = Input.GetAxis ("Vertical");



		if (Grounded == true && (Input.GetKey ("space"))){ //If the player is on the ground (True) and you press the Spacebar
			rigidbody.AddForce (rigidbody.velocity += Vector3.up * Jump_Force);
			Grounded = false; //Set grounded to false again because the player is in the air
		} else {
			rigidbody.AddForce (-Vector3.up * Gravity * Time.deltaTime); //Gravity
		}

		//Check if player is on ground
		if (Grounded == false) { //Debug
			Debug.Log ("Grounded");
		}

        Vector3 movement = new Vector3(X, 0, Z);
		movement.Normalize ();
        //rigidbody.AddForce(movement * Player_Speed);
		rigidbody.AddForce(new Vector3(0,0,0).normalized*moveSpeed*Time.deltaTime);


		Debug.Log ("X: " + X + " Z: " + Z); //debug
	}

	void OnCollisionEnter(Collision collision) { //Check if the player is on the ground!
	
		if (collision.collider.gameObject.tag == "Ground") {
			Grounded = true;
			Debug.Log ("touching ground"); //Debug
		} else {
			Grounded = false;
		}
	}
}
