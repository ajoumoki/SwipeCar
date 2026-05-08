using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcontroler : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0;
    Vector2 startPos;  // 마우스를 처음 클릭한 위치 저장
    GameObject flag;  // 깃발(GameObject) 저장 변수
    void Start()
    {
        flag = GameObject.Find("flag");   // 이름이 "flag"인 게임오브젝트 찾기
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))  // 마우스 왼쪽 버튼을 뗐을 때
        {
            Vector2 endPos = Input.mousePosition; // 현재 마우스 위치 저장
            float swipeLength = endPos.x - this.startPos.x; // 시작 위치와 끝 위치의 x축 차이 계산
            this.speed = swipeLength / 500.0f;  // 스와이프 길이에 비례하여 속도 설정
            GetComponent<AudioSource>().Play(); // 자동차 오디오 재생
        } 
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼을 눌렀을 때
        {
            this.speed = 0.2f; 
        }
        transform.Translate(this.speed, 0, 0); //속도값만큼 이동
        this.speed *= 0.98f; //속도 감소
        
    }
}
