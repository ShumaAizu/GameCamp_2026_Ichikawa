using UnityEngine;
using UnityEngine.SceneManagement;

public class LastScore : MonoBehaviour
{
    // シーンをまたいで残る最終スコア(ResultManagerから読む)
    public static int FinalScore { get; private set; }

    [SerializeField] private ScoreDisplay scoreDisplay;               // スコア表示(Inspectorで設定)
    [SerializeField] private string resultSceneName = "Result";       // 遷移先シーン名
    [SerializeField] private float timeLimit = 120.0f;                // 制限時間(秒)

    private float _timer;
    private bool _isChanging;

    void Update()
    {
        if (_isChanging) return;

        _timer += Time.deltaTime;

        if (_timer >= timeLimit)
        {
            _isChanging = true;
            FinalScore = scoreDisplay.TotalScore;   // スコアを保存
            SceneManager.LoadScene(resultSceneName); // リザルトへ遷移
        }
    }
}