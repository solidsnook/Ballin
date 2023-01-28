using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallBouncer : MonoBehaviour
{
    Rigidbody m_player;
    public float forceValue;
    // Start is called before the first frame update
    void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 v = m_player.velocity;
        m_player.AddForce(Vector3.up * forceValue, ForceMode.Impulse); // Used ChatGPT to receive this method.

    }    

    void OnCollisionExit(Collision collision)
    {
     //  to add code here.
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
