using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class rockAnimScript : MonoBehaviour
{
    public GameManager manager;
    Animator anim;
    public TMP_Text gameovertxt;
    // Start is called before the first frame update
    void Start()
    {
        gameovertxt.text = "";
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.endGame()) {anim.SetBool("gameOver", true); gameovertxt.text = "GAME OVER!!! The Great Rock has come to claim the land!"; }
    }
}
