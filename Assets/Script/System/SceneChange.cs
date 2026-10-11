//*************************************************************
//
// シーン変更 [SceneChange.cs ]
// Author : SHUMA AIZU
//
//*************************************************************

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
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
        
    }

    //=========================================================
    // シーン変更
    //=========================================================
    public void OnButtonClicked()
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
