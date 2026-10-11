//*************************************************************
//
// ライセンス表示状態設定 [LicenseView.cs ]
// Author : SHUMA AIZU
//
//*************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class LicenseView : MonoBehaviour
{
    // 変数
    private bool isEnable;                        // 表示状態
    [SerializeField] private GameObject License;  // ライセンス

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
        if(Keyboard.current.escapeKey.isPressed)
        {
            OffActive();
        }
    }

    //=========================================================
    // 表示
    //=========================================================
    public void OnActive()
    {
        if(isEnable == true)
        {// 表示されていたらスキップ
            return;
        }

        // 表示
        isEnable = true;
        License.SetActive(isEnable);
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
        License.SetActive(isEnable);
    }
}
