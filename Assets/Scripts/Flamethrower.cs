using UnityEngine;
using System.Collections;

public class Flamethrower : MonoBehaviour {

    public float offset;
    float timer;

	// Use this for initialization
	void Start () {
        timer = offset * 60;
        
	}
	
	// Update is called once per frame
	void Update () {
        timer++;
        if (timer > 120)
        {
            particleSystem.Play();
            light.intensity = 4;
        }
        else 
        { 
            particleSystem.Stop();
            light.intensity = 0;
        }

        if (timer > 240)
        {
            timer = 0;
        }
	
	}
}
