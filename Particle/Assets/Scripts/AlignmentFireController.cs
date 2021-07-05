using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignmentFireController : MonoBehaviour
{
    // prefabの情報を保持するための変数
    public GameObject originalFire;

    void Start()
    {
        // 整列した炎を生成
        for (int i = 0; i < 20; i ++) {
            Vector3 pos = new Vector3( -1, 0, i*2 );
            AlignmentFire(pos);

            pos = new Vector3( 3, 0, i*2);
            AlignmentFire(pos);
        }
    }

    /// <summary>
    /// 指定された位置に炎生成する
    /// </summary>
    void AlignmentFire(Vector3 position) {
        GameObject fire = Instantiate(originalFire);
        fire.transform.position = position;
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
