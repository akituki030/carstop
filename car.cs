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
            starPos = Input.mousePosition;//�N�I���ƹ��ɪ��y�аO���U��
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;//�N��}�ƹ��ɪ��y�Ь����_��
            float swipeLength = endPos.x - starPos.x;
            myspeed = swipeLength / 500.0f;//��ƹ��ưʪ��׶Ǵ�����l���ʳt��
        }
        transform.Translate(myspeed, 0, 0);
        myspeed *= 0.98f;
    }
}
