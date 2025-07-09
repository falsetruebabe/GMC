using UnityEngine;

// 컬러를 바꾸고 싶다.
public class ColorChange : MonoBehaviour
{

    Renderer rend;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /***
         * 내가(Game Object) 가지고 있는 랜더러(mesh Renderer)를 변수에 담아라
         * 랜더러가 가지고 있는 머터리얼의 컬러를 red로 바꿔라
         ***/

        rend = GetComponent<Renderer>();
        rend.material.color = Color.red;
        //아래 코드와 동일함
        //GetComponent<Renderer>().material.color = Color.red;

        transform.position = new Vector3(100, 20, -50); // 위치 이동 game play 버튼을 누르면 위치가 이동하고 색깔이 보라색으로 변함
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = Color.purple; // game play 버튼을 누르면 위치가 이동하고 색깔이 보라색으로 변함
    }
}
