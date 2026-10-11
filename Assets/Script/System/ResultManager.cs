//*************************************************************
//
// リザルト管理 [ResultManager.cs ]
// Author : SHUMA AIZU
//
//*************************************************************

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class ResultManager : MonoBehaviour
{
    // 変数
    [SerializeField] private TextMeshProUGUI ScoreText;     // スコア表示用テキスト
    [SerializeField] private GameObject Rank;               // ランク
    private GameObject CreateRank;

    //=========================================================
    // 初期化
    //=========================================================
    void Start()
    {
        // スコアの値を受け取って入れる 今は仮置き
        int nTest = 1000;
        ScoreText.text = nTest.ToString();

        CreateRank = Instantiate(Rank, new Vector3(250.0f, 250.0f, 0.0f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));

        RankSetting rankSetting = CreateRank.GetComponent<RankSetting>();
        rankSetting.SetRank(nTest);
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
}
