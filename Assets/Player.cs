using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float Player_Speed = 25f;
	public float Jump_Force = 400f;
	public float Gravity = 50f;
	public bool Grounded = false;

	//Rigibody Settings:
	//Mass = 1
	//Drag = 1
	//Angular Drag == 0.05
	//Use Gravity = On
	//Is Kinematic = Off
	//Interpolate = none
	//Collison = Discrete
	//Constaints:
	//Freeze Postion = X=Off | Y=Off | Z=On
	//Freeze Rotation = X=Off | Y=Off | Z=Off

	void Update () {
		
		float X = Input.GetAxis ("Horizontal")*Player_Speed;
		float Z = Input.GetAxis ("Vertical")*Player_Speed;

		if (Grounded == true && (Input.GetKey ("space"))){ //If the player is on the ground (True) and you press the Spacebar
			rigidbody.AddForce (Vector3.up * Jump_Force);
			Grounded = false; //Set grounded to false again because the player is in the air
		} else {
			rigidbody.AddForce (-Vector3.up * Time.deltaTime * Gravity); //Gravity
		}

		//Check if player is on ground
		if (Grounded == false) { //Debug
			Debug.Log ("Grounded");
		}

        Vector3 movement = new Vector3(X, 0, Z);
        rigidbody.AddForce(movement);


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
