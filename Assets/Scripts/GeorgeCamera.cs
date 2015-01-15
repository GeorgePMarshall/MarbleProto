using UnityEngine;
using System.Collections;

public class GeorgeCamera : MonoBehaviour
{


    public Transform target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        Vector3 ball = new Vector3(target.position.x + 20, target.position.y + 5, target.position.z);
        transform.position = ball;

    }
}

