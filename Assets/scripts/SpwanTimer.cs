using UnityEngine;
// want: enemy or item�� ���� �ð��� �Ǹ� ����(����)�ϴ� ���
public class SpwanTimer : MonoBehaviour
{

    public float spawnTime = 5; // 5��
    public float curTime = 0;
    public GameObject spawnObj; // �����ؾ��� ������Ʈ

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // creat: Timer
        curTime = curTime + Time.deltaTime; // ���� 
        if (curTime > spawnTime)
        {
            // item, enemy -> �����ض�
            GameObject item = Instantiate(spawnObj); // item
            curTime = 0; // curTime �ʱ�ȭ
        }
    }
}
