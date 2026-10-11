using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    private TextMeshProUGUI _scoretext;
    private int _totalscore;

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
