using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFireController : MonoBehaviour
{
    // prefabの情報を保持するための変数
    public GameObject originalFire;

    void Start()
    {
        //ランダムに炎生成
        for (int i = 0; i < 30; i++) {
            CreateRandomFire();
        }
    }

    /// <summary>
    /// ランダムに炎を生成
    /// </summary>
    void CreateRandomFire() {
        GameObject fire = Instantiate(originalFire);
        Vector3 pos = new Vector3(
            Random.Range(-5.0f, 5.0f),
            0,
            Random.Range(-5.0f, 5.0f)
        );
        fire.transform.position = pos;
    }

    void Update()
    {
    }
}
