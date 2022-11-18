using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMster : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject car;
    GameObject flag;
    GameObject distance;
    float  point = 100f;
    float poi = 0f;
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("distance");

    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length < 16f)
        {
            
            poi = point / length;

        }
        if (this.flag.transform.position.x<this.car.transform.position.x)
        {
            poi = 0;
        }

        this.distance.GetComponent<Text>().text = "距離目標還有:" + length.ToString("F2") + "m"+"分數"+poi.ToString("F2");;
        
    }

}
