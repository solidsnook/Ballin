using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObeliskAnimScript : MonoBehaviour
{
    public GameManager manager;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (manager.isDesertGoalTileActivated == true) { anim.SetBool("goalTrigger", true); }
    }
}
