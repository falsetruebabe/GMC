using UnityEngine;

public class FuncOperation : MonoBehaviour
{
    // ���� Ÿ��(int) ������(num) = �ʱⰪ(0);
    public int num1 = 3; // public == ����
    private int num2 = 2; // (private == �����) �������� i.e. ���û���
    int result = 0;

    /* ��ȯ��(void) �Լ���(Add) () {}
     * ��ȯ������ void �̿ܿ� e.g. int ���� �� ���� ������ return �� ����ؾߵ�
     *  + �������� ù���� �ҹ��� �Լ����� ù���� �빮�ڷ� ���ڰ� �ϱ��ϴµ� ���� ���� �ȸ���
     */
    //void Add() // ���� �Լ� 
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
