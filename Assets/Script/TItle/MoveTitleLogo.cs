//*************************************************************
//
// ロゴの移動 [MoveTitleLogo.cs ]
// Author : SHUMA AIZU
//
//*************************************************************
using UnityEngine;

public class MoveTitleLogo : MonoBehaviour
{
    // 変数
    [SerializeField] private float fSpeed = 1.0f;
    [SerializeField] private float fHeight = -300.0f;
    [SerializeField] private GameObject titleManager;
    private TitleManager manager;

    //=========================================================
    // 初期化
    //=========================================================
    void Start()
    {
        // タイトルマネージャーを取得
        manager = titleManager.GetComponent<TitleManager>();
    }

    //=========================================================
    // 更新
    //=========================================================
    void Update()
    {
        // 現在の状態を取得
        TitleManager.STATE state = manager.GetState();

        if (state == TitleManager.STATE.STATE_OP)
        {// 状態がオープニングだったら
            // 定位置か参照するために現在位置を取得
            Vector2 position = transform.position;

            if (position.y > fHeight)
            {// 定位置でなければ移動させる
                transform.Translate(0.0f, -fSpeed, 0.0f);
            }
        }
    }
}
