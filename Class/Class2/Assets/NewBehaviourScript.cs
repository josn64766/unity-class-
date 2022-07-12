using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour // main 함수
{
    // 필드 
    // 변수 선언
    // C# 파스칼 표기법과 카멜 표기법을 사용

    int health; // <-초기화를 하지 않아도 자동 초기화(0으로)

    void Start()  // c++ 초기화(생성자) 함수
    {
        health = 100;
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
