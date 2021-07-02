using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    //prefabをセットする
    public GameObject prefabFire;
    // ParticleSystem originalFire;

    void Start()
    {
        AlignGenerate();
    }

    void AlignGenerate() {
        for(int i = 0; i <=10; i++) {
            // 左列
            GameObject obj;
            obj = Instantiate(prefabFire);
            obj.transform.position = new Vector3(i*2, 0, 1.5f);

            obj = Instantiate(prefabFire);
            obj.transform.position = new Vector3(i*2, 0, -1.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
