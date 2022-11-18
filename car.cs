using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float myspeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            myspeed = 0.2f;
        }
        transform.Translate(myspeed, 0, 0);
        myspeed *= 0.98f;
    }
}
