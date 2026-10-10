//*************************************************************
//
// リザルト管理 [ResultManager.cs ]
// Author : SHUMA AIZU
//
//*************************************************************

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    //=========================================================
    // 初期化
    //=========================================================
    void Start()
    {
        
    }

    //=========================================================
    // 更新
    //=========================================================
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {// 左クリックが押されたら
            // シーン変更
            SceneChange();
        }
    }

    //=========================================================
    // シーン変更
    //=========================================================
    private void SceneChange()
    {
        // 現在のシーン番号に1を足した数字を持っておく
        int nSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        // 最大シーン番号と比較して超えそうになったら0に戻す
        if (nSceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
            nSceneIndex = 0;
        }

        SceneManager.LoadScene(nSceneIndex); // シーンチェンジ
    }
}
