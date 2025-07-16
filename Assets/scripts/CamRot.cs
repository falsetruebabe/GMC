using UnityEngine;
// want: 카메라를 마우스로 제어(회전)
public class CamRot : MonoBehaviour
{
    public float mouseSpd = 200f; // 마우스 감도
    float mx = 0f; // 마우스x값을 저장
    float my = 0f; // 마우스y값을 저장

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // want: 마우스의 움직임에 대한 값 받아오기
        float mouse_x = Input.GetAxis("Mouse X");
        float mouse_y = Input.GetAxis("Mouse Y");

        // P = p0 + vt 공식 적용
        mx = mx + mouse_x * mouseSpd * Time.deltaTime;
        my = my + mouse_y * mouseSpd * Time.deltaTime;

        // 값을 제한한다 Math.Clamp(제한할 변수, min, max)
        my = Mathf.Clamp(my, -90, 90); // 카메라의 상하각도를 -90~90도로 제한
        transform.eulerAngles = new Vector3(-my, mx, 0);
    }
}
