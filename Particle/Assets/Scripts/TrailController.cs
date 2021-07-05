using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailController : MonoBehaviour
{
    const float distance = 3.0f;
    const float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        Vector3 pos = transform.position;
        pos.x = Mathf.Sin(time * speed) * distance;
        pos.y = Mathf.Cos(time * (speed * 0.5f)) * distance;
        transform.position = pos;
    }
}
