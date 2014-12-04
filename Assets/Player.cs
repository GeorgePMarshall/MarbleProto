using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    float Y = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float X = Input.GetAxis("Horizontal")*10;
        float Z = Input.GetAxis("Vertical")*10;
        
        if(Input.GetKey("space"))
        {
             Y = 30;
        }
        else
        {
             Y = 0;
        }

        Vector3 movement = new Vector3(X, Y, Z);
        rigidbody.AddForce(movement);
	}
}
