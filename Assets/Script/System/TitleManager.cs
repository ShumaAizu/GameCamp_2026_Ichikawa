//*************************************************************
//
// タイトル管理 [TitleManager.cs ]
// Author : SHUMA AIZU
//
//*************************************************************

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class TitleManager : MonoBehaviour
{
    //=========================================================
    // 状態
    //=========================================================
    public enum STATE
    { 
        STATE_OP = 0,       // オープニング
        STATE_WAIT,         // 待機
        STATE_FADE,         // 画面遷移
        STATE_MAX           // 最大数
    };

    // 変数
    STATE currentState;     // 現在の状態

    //=========================================================
    // 初期化
    //=========================================================
    void Start()
    {
        // 初期設定
        currentState = STATE.STATE_OP;
    }

    //=========================================================
    // 更新
    //=========================================================
    void Update()
    {
#if false
        if (Mouse.current.leftButton.isPressed)
        {// 左クリックが押されたら
            // シーン変更
            SceneChange();
        }
#endif
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

    //=========================================================
    // 状態取得
    //=========================================================
    public STATE GetState()
    {
        // 現在の状態を返す
        return currentState;
    }
}
