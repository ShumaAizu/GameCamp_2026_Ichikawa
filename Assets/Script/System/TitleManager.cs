using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    //=========================================================
    // 更新
    //=========================================================
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {// 押されたら
            // 現在のシーン番号に1を足した数字を持っておく
            int nSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

            // 最大シーン番号と比較して超えそうになったら0に戻す
            if (nSceneIndex >= SceneManager.sceneCountInBuildSettings)
            {
                nSceneIndex = 0;
            }

            SceneChange(nSceneIndex);
        }
    }

    //=========================================================
    // シーン変更
    //=========================================================
    public void SceneChange(int nSceneIndex)
    {
        SceneManager.LoadScene(nSceneIndex); // シーンチェンジ
    }
}
