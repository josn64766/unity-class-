using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour // main �Լ�
{
    // �ʵ� 
    // ���� ����
    // C# �Ľ�Į ǥ����� ī�� ǥ����� ���

    int health; // <-�ʱ�ȭ�� ���� �ʾƵ� �ڵ� �ʱ�ȭ(0����)

    void Start()  // c++ �ʱ�ȭ(������) �Լ�
    {
        health = 100;
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
