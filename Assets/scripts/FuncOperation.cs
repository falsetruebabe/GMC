using UnityEngine;

public class FuncOperation : MonoBehaviour
{
    // 변수 타입(int) 변수명(num) = 초기값(0);
    public int num1 = 3; // public == 공개
    private int num2 = 2; // (private == 비공개) 생략가능 i.e. 선택사항
    int result = 0;

    /* 반환형(void) 함수명(Add) () {}
     * 반환형에서 void 이외에 e.g. int 같은 거 쓰면 무조건 return 값 사용해야됨
     *  + 변수명은 첫글자 소문자 함수명은 첫글자 대문자로 하자고 하긴하는데 나랑 존나 안맞음
     */
    //void Add() // 덧셈 함수 
    //{
    //    result = num1 + num2;
    //}

    int add()
    {
        result = num1 + num2;
        return result;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(add());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
