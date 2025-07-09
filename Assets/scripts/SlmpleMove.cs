using UnityEngine;

// want: ���� ������ �������� �̵� == position�� ���� ����
public class SlmpleMove : MonoBehaviour
{
    // �̵� �� ��� �ڷ��� - float: �Ǽ�, Vector3: ����(x,y,z)
    public Vector3 dir = new Vector3(0, 0, 1); // front�� �ǹ��ϴ� z:1
    public float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // want: ���� �Է��� �������� �̵�
        float h = Input.GetAxis("Horizontal"); // a(-1) or d(+1)�� ���� �� 
        float v = Input.GetAxis("Vertical"); // s(-1) or w(+1)�� ���� �� 

        dir = new Vector3(h, 0, v);

        // ����ȭ Normalize == ������ ���̸� 1�� ������ �����ϸ鼭 ������ ���̸� 1�� ����
        dir.Normalize();

        // ��ġ�� ����ؼ� ���� 
        // P(�� ��ġ) = p0(���� ��ġ) + v(����) * t(�ð�) 
        // =(��ȣ) ���� L: ���� R: ���� �޾ƿ� // ������ ���ؼ� update���� == x������ += 1f
        transform.position += dir * speed * Time.deltaTime;
        // == transform.position = transform.position + dir;
        // dir == new Vector3(1f /* float���� �������� ��� */, 0, 0);
        // == transform.Translate(dir * speed * Time.deltaTime); 
        // want: ���� ������ �������� �̵�
    }
}

/* dev note
 * Update �Լ����ٰ� transform.position ���ԵǸ� transform ���� X(����)
 * but Start���ٰ� ���� transform ���� O 
 * a(�� ��ǥ��) = p(���� ��ġ) + vt(�ӵ�==����*�ð�)
 */