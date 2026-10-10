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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
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
