using UnityEngine;

// want: 내가 지정한 방향으로 이동 == position의 값이 변함
public class SlmpleMove : MonoBehaviour
{
    // 이동 시 사용 자료형 - float: 실수, Vector3: 벡터(x,y,z)
    public Vector3 dir = new Vector3(0, 0, 1); // front를 의미하는 z:1
    public float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // want: 내가 입력한 방향으로 이동
        float h = Input.GetAxis("Horizontal"); // a(-1) or d(+1)를 누를 때 
        float v = Input.GetAxis("Vertical"); // s(-1) or w(+1)를 누를 때 

        dir = new Vector3(h, 0, v);

        // 정규화 Normalize == 벡터의 길이를 1로 방향을 유지하면서 벡터의 길이를 1로 고정
        dir.Normalize();

        // 위치를 계속해서 변경 
        // P(새 위치) = p0(기존 위치) + v(방향) * t(시간) 
        // =(등호) 기준 L: 대입 R: 값을 받아옴 // 방향을 더해서 update해줌 == x축으로 += 1f
        transform.position += dir * speed * Time.deltaTime;
        // == transform.position = transform.position + dir;
        // dir == new Vector3(1f /* float형의 숫자임을 명시 */, 0, 0);
        // == transform.Translate(dir * speed * Time.deltaTime); 
        // want: 내가 지정한 방향으로 이동
    }
}

/* dev note
 * Update 함수에다가 transform.position 적게되면 transform 변경 X(고정)
 * but Start에다가 쓰면 transform 변경 O 
 * a(새 좌표값) = p(현재 위치) + vt(속도==방향*시간)
 */