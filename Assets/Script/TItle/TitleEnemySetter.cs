//*************************************************************
//
// タイトルでの敵設定 [TitleEnemySetter.cs ]
// Author : SHUMA AIZU
//
//*************************************************************

using UnityEngine;

public class TitleEnemySetter : MonoBehaviour
{
    // 変数
    [SerializeField] private GameObject[] Enemy;            // 敵の種類分
    [SerializeField] private Vector2[] EnemyPosition;       // 位置

    //=========================================================
    // 初期設定
    //=========================================================
    void Start()
    {
        for(int nCnt = 0; nCnt < EnemyPosition.Length; nCnt++)
        {
            Create(nCnt);
        }
    }

    //=========================================================
    // 更新
    //=========================================================
    void Update()
    {
        
    }

    //=========================================================
    // 敵設定
    //=========================================================
    private void Create(int nIdx)
    {
        // ランダムな種類に
        int nTypeIdx = Random.Range(0, Enemy.Length);

        // 敵を生成
        Instantiate(Enemy[nTypeIdx], EnemyPosition[nIdx], new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
    }
}
