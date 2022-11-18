using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float myspeed = 0f;
    Vector2 starPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            starPos = Input.mousePosition;//將點擊滑鼠時的座標記錄下來
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;//將放開滑鼠時的座標紀錄起來
            float swipeLength = endPos.x - starPos.x;
            myspeed = swipeLength / 500.0f;//把滑鼠滑動長度傳換成初始移動速度
        }
        transform.Translate(myspeed, 0, 0);
        myspeed *= 0.98f;
    }
}
