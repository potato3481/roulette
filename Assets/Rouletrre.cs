using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rouletrre : MonoBehaviour
{
    float rotSpeed = 0; //ȸ�� �ӵ�

    void Start()
    {
        
    }

    
    void Update()
    { // Ŭ���ϸ� ȸ���ӵ� ����
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;

        }
        //ȸ�� �ӵ���ŭ ȸ�� ��Ų��
        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.99f;
    }
}
