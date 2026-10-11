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
    [SerializeField] private GameObject[] EnemyCpy;         // 敵保存用
    [SerializeField] private Vector2[] EnemyPosition;       // 位置

    private int nMax;                                       // 最大数

    //=========================================================
    // 初期設定
    //=========================================================
    void Start()
    {
        // 敵の最大数
        nMax = EnemyPosition.Length;

        // 最初に全部作っておく
        for (int nCnt = 0; nCnt < nMax; nCnt++)
        {
            // 生成
            Create(nCnt);
        }
    }

    //=========================================================
    // 更新
    //=========================================================
    void Update()
    {
        // オブジェクトが存在しているかチェック
        for(int nCnt = 0; nCnt < nMax; nCnt++)
        {
            if(EnemyCpy[nCnt] != null)
            {// オブジェクトが存在していたら
                // スキップ
                continue;
            }

            // 存在しなければ再生成
            Create(nCnt);
        }
    }

    //=========================================================
    // 敵設定
    //=========================================================
    private void Create(int nIdx)
    {
        // ランダムな種類に
        int nTypeIdx = Random.Range(0, Enemy.Length);

        // 敵を生成
        EnemyCpy[nIdx] = Instantiate(Enemy[nTypeIdx], EnemyPosition[nIdx], new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
    }
}
