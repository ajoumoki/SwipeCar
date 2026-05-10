using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject car; // 자동차(GameObject) 저장 변수
    GameObject flag; // 깃발(GameObject) 저장 변수
    GameObject distance; // 거리(GameObject) 저장 변수
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x; //length를 깃발의 x 빼기 자동차의 x의 값으로 지정
        this.distance.GetComponent<UnityEngine.UI.Text>().text = "¸ñÇ¥ ÁöÁ¡±îÁö" + length.ToString("F2") + "m"; //UI 지정
    }
}
