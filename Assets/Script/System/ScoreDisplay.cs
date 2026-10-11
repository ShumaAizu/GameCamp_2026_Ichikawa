using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    private TextMeshProUGUI _scoretext;
    private int _totalscore;

    // 追加:現在のスコアを外部から読み取れるようにする
    public int TotalScore => _totalscore;

    private void Awake()
    {
        _scoretext = GetComponent<TextMeshProUGUI>();
        _scoretext.text = _totalscore.ToString();
    }

    public void AddScore(int amount)
    {
        _totalscore += amount;
        _scoretext.text = _totalscore.ToString();
    }
}