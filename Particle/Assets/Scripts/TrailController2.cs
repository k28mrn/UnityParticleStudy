using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed  = 2.0f;
        float distance = 5.0f;
        Vector3 pos2 = this.transform.position;
        //Time.time : 経過時間
        pos2.x = Mathf.Cos(Time.time * speed) * distance;
        pos2.y = Mathf.Sin((Time.time * speed) * 2.0f) * distance;
        this.transform.position = pos2;

        if (Input.GetKey(KeyCode.UpArrow)) { //上矢印
            Vector3 pos = this.transform.position;
            pos.y += 0.1f;
            this.transform.position = pos;
        } else if (Input.GetKey(KeyCode.DownArrow)) { //下矢印
            Vector3 pos = this.transform.position;
            pos.y -= 0.1f;
            this.transform.position = pos;
        } else if (Input.GetKey(KeyCode.LeftArrow)) { //左矢印
            Vector3 pos = this.transform.position;
            pos.x -= 0.1f;
            this.transform.position = pos;
        } else if (Input.GetKey(KeyCode.RightArrow)) { //右矢印
            Vector3 pos = this.transform.position;
            pos.x += 0.1f;
            this.transform.position = pos;
        }
    }
}
