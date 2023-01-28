using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertGoal : MonoBehaviour
{
    public GameManager manager;
    private GameObject m_player;
    // Start is called before the first frame update
    void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
    }


    void OnCollisionEnter(Collision collision)
    {
        manager.desertGoal();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
