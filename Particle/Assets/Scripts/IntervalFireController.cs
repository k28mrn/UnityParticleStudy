using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervalFireController : MonoBehaviour
{
    // prefabの情報を保持するための変数
    public GameObject originalFire;

    // 炎生成の間隔
    float createInterval = 0.6f;
    
    // 炎生成した時間
    float startedTime = 0.0f;

    void Start()
    {
        //開始時刻
        // Time.time : アプリの起動後の経過時間
        startedTime = Time.time;

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
        //経過時刻
        float elapsed = Time.time - startedTime;

        // 炎生成のインターバルと経過時間を比較して
        // 経過時間が過ぎている場合は炎生成
        if (elapsed > createInterval) {
            CreateRandomFire();

            //開始時刻をリセット
            startedTime = Time.time;
        }
    }
}
