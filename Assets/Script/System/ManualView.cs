//*************************************************************
//
// マニュアル表示状態設定 [ManualView.cs ]
// Author : SHUMA AIZU
//
//*************************************************************

using UnityEngine.InputSystem;
using UnityEngine;

public class ManualView : MonoBehaviour
{
    // 変数
    private bool isEnable;                        // 表示状態
    [SerializeField] private GameObject Manual;   // マニュアル

    //=========================================================
    // 初期化
    //=========================================================
    void Start()
    {
        // 最初は非表示
        isEnable = false;
    }

    //=========================================================
    // 更新
    //=========================================================
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            OffActive();
        }
    }

    //=========================================================
    // 表示
    //=========================================================
    public void OnActive()
    {
        if (isEnable == true)
        {// 表示されていたらスキップ
            return;
        }

        // 表示
        isEnable = true;
        Manual.SetActive(isEnable);
    }

    //=========================================================
    // 非表示
    //=========================================================
    public void OffActive()
    {
        if (isEnable == false)
        {// 非表示だったらスキップ
            return;
        }

        // 非表示
        isEnable = false;
        Manual.SetActive(isEnable);
    }
}
