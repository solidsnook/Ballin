using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WarpGate : MonoBehaviour
{
    private GameManager Manager;
    private GameObject m_player;
    public GameObject WarpGateEnd;
    public Vector3 DestinationPos;
    // Start is called before the first frame update
    void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
        Manager = GameManager.Instance;
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.name + " touched the collider");
        //DestinationPos = WarpGateEnd.transform.position + 0.5f * Vector3.forward;
        m_player.transform.position = WarpGateEnd.transform.position + DestinationPos; // Dev Note. DestinationPos is called as public variable so that it can be changed easier when viewing it in Unity.
        //  You want to change this due to the positioning of the warp gates. Change the value to what seems fit from the attached object to affect the gate you will exit from.
        //  EG: If attached to gate 1 and it is going to gate 2. Change the values so that the ball exits correctly from gate 2.
    }

    void OnTriggerExit(Collider collision)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
