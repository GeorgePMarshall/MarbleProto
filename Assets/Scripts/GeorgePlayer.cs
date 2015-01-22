using UnityEngine;
using System.Collections;

public class GeorgePlayer : MonoBehaviour {
    
    public float Player_Speed = 25f;
	bool onGround = false;
    float Y;
    Vector3 startLocation;
	
	void Start () {
        startLocation = transform.position;
	}
	
	// Update is called once per frame
	

	void Update () {
		
		float Z = Input.GetAxis ("Horizontal")*Player_Speed;
		float X = Input.GetAxis ("Vertical")*Player_Speed;

		if (Input.GetKeyDown (KeyCode.Space) && onGround == true)
        {
             Y = 500;
        }
        else
        {
            Y = -10;

        }

        onGround = false;
        
        if(transform.position.y < 20)
        {
            transform.position = startLocation;
            rigidbody.velocity = Vector3.zero;
        }


        Vector3 movement = new Vector3(X*-0.5f, Y, Z);
        rigidbody.AddForce(movement);
	}

    void OnCollisionStay(Collision coll)
    {
        if (coll.transform.tag == "Ground")
        {
            onGround = true;
          
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("player_collision:" + coll.transform.tag);
        if(coll.transform.tag == "Hazard")
        {
            rigidbody.velocity = coll.relativeVelocity*2;
            
        }
        if(coll.transform.tag == "Finish")
        {
            Application.LoadLevel("Rhys");
            Debug.Log("Level Complete");
        }
    }

    void OnParticleCollision(GameObject coll)
    {
        rigidbody.AddForce(new Vector3(50, 0, 0));
    }

}
