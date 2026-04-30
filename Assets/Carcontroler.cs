using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcontroler : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0;
    Vector2 startPos;
    GameObject flag;
    void Start()
    {
        flag = GameObject.Find("flag");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = flag.transform.position;  
        }
        /*else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;
            this.speed = swipeLength / 500.0f;
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetMouseButtonDown(0))
        {
            this.speed = 0.2f;
        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;*/
        
    }
}
