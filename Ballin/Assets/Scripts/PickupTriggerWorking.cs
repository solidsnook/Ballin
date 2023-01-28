using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTriggerWorking : MonoBehaviour
{
    Rigidbody m_player;

    public GameManager manager;
    // Write code so that when the Player enters the trigger zone of the
    // pickup, the method pickup() of the GameManager is called and the
    // pickup gameobject is destroyed. 
    // The player can be detected by checking that its tag is Player
    void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider col)
    {
        // Imported from SciFiGameTemplate
        if (col.gameObject.tag == "Player")
        {
            manager.pickup();
            Destroy(gameObject);
        }
    }
}
