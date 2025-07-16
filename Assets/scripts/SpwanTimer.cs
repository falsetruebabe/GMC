using UnityEngine;
// want: enemy or item을 일정 시간이 되면 스폰(생성)하는 기능
public class SpwanTimer : MonoBehaviour
{

    public float spawnTime = 5; // 5초
    public float curTime = 0;
    public GameObject spawnObj; // 생성해야할 오브젝트

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // creat: Timer
        curTime = curTime + Time.deltaTime; // 누적 
        if (curTime > spawnTime)
        {
            // item, enemy -> 실행해라
            GameObject item = Instantiate(spawnObj); // item
            curTime = 0; // curTime 초기화
        }
    }
}
