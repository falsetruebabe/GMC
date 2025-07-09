using UnityEngine;

// �÷��� �ٲٰ� �ʹ�.
public class ColorChange : MonoBehaviour
{

    Renderer rend;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /***
         * ����(Game Object) ������ �ִ� ������(mesh Renderer)�� ������ ��ƶ�
         * �������� ������ �ִ� ���͸����� �÷��� red�� �ٲ��
         ***/

        rend = GetComponent<Renderer>();
        rend.material.color = Color.red;
        //�Ʒ� �ڵ�� ������
        //GetComponent<Renderer>().material.color = Color.red;

        transform.position = new Vector3(100, 20, -50); // ��ġ �̵� game play ��ư�� ������ ��ġ�� �̵��ϰ� ������ ��������� ����
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = Color.purple; // game play ��ư�� ������ ��ġ�� �̵��ϰ� ������ ��������� ����
    }
}
