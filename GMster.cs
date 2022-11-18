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
    GameObject QAQ;
    float poin = 0f;
    

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("distance");
        this.QAQ = GameObject.Find("QAQ");

    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        
        if (length < 16)
        {
             poin = (car.transform.position.x - QAQ.transform.position.x) / (flag.transform.position.x - QAQ.transform.position.x)*100;
            
            
        }
        if (this.flag.transform.position.x<this.car.transform.position.x)
        
        {
            poin = 0;
        }
        

        this.distance.GetComponent<Text>().text = "距離目標還有:" + length.ToString("F2") + "m"+"分數"+poin.ToString("F2");;
        
    }

}
