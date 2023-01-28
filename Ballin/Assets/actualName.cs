using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actualName : MonoBehaviour
{
    public GameObject ballAgain;
    Vector3 p;
    // Start is called before the first frame update
    void Start()
    {
       p = ballAgain.transform.position;
        p.y = p.y + 5;
        transform.position = p;
    }

    // Update is called once per frame
    void Update()
    {
        p = ballAgain.transform.position;
        p.y = p.y + 3;
        transform.position = p;
    }
}
