using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

    float speed = 0.05f;

	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x >= 94)
        {
            speed = -0.05f;
        }
        else if(transform.position.x <= 84)
        {
            speed = 0.05f;
        }
        
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);

	}
}
