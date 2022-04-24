using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rouletrre : MonoBehaviour
{
    float rotSpeed = 0; //회전 속도

    void Start()
    {
        
    }

    
    void Update()
    { // 클릭하면 회전속도 설정
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;

        }
        //회전 속도만큼 회전 시킨다
        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.99f;
    }
}
