using UnityEngine;

public class PrintHelloWorld : MonoBehaviour
{
    //int Main()
    //{
    //    return 1 + 1;
    //}

    /***
    * Start is called once before the first execution of Update after the MonoBehaviour is created 
    * Start button 누르면 딱 한 번만 실행함 
    * i.e. Hello World 를 플레이버튼 누르면 한번만 실행한다는 말을 직역한 거임 
    * 초기화: 초기 값 셋팅 (에 많이 쓰임)
    ***/
    void Start()
    {
        print("Hello World!");

        int num1 = 1; // num 1 & 2 is 변수(var)
        int num2 = 2;
        print(num1 + num2);

        Color apple = Color.red; // apple is red
    }

    /*** 
    * Update is called once per frame 
    * i.e. 업데이트는 frame 당 1번 출력 
    * 진행중인 값의 변화를 계산
    ***/
    void Update()
    {
        print(1 + 1);
    }
}
