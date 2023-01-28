using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject rollerBall;
    public GameObject empty;
    Vector3 vel;
    Vector3 normalV;

    Vector3 normal;
    float magnitude;

    // Start is called before the first frame update
   
    void Start()
    {
        
        vel = rollerBall.GetComponent<Rigidbody>().velocity;
        magnitude = vel.magnitude;
        normal.x = (vel.x / magnitude * -4);
        normal.y = (vel.y / magnitude * -1 + 3);
        normal.z= (vel.z / magnitude * -4);
        transform.position = normal;

    }

    // Update is called once per frame
    void Update()
    {
        vel = rollerBall.GetComponent<Rigidbody>().velocity;
        magnitude = vel.magnitude;
        normal.x = (vel.x / magnitude * -8);
        normal.y = (vel.y / magnitude * -1 + 3);
        normal.z = (vel.z / magnitude * -8);
        normal = normal + rollerBall.transform.position;
        transform.position = normal;

        transform.LookAt(empty.transform.position);
     

        //point
    }
}
