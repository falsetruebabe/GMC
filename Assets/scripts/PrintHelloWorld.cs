using UnityEngine;

public class PrintHelloWorld : MonoBehaviour
{
    //int Main()
    //{
    //    return 1 + 1;
    //}

    /***
    * Start is called once before the first execution of Update after the MonoBehaviour is created 
    * Start button ������ �� �� ���� ������ 
    * i.e. Hello World �� �÷��̹�ư ������ �ѹ��� �����Ѵٴ� ���� ������ ���� 
    * �ʱ�ȭ: �ʱ� �� ���� (�� ���� ����)
    ***/
    void Start()
    {
        print("Hello World!");

        int num1 = 1; // num 1 & 2 is ����(var)
        int num2 = 2;
        print(num1 + num2);

        Color apple = Color.red; // apple is red
    }

    /*** 
    * Update is called once per frame 
    * i.e. ������Ʈ�� frame �� 1�� ��� 
    * �������� ���� ��ȭ�� ���
    ***/
    void Update()
    {
        print(1 + 1);
    }
}
