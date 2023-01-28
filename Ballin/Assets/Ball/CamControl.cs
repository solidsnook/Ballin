using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public GameObject ball;
    Transform getZ;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
