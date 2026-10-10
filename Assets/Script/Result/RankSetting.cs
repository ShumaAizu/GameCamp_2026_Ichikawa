//*************************************************************
//
// ランク設定 [RankSetting.cs ]
// Author : SHUMA AIZU
//
//*************************************************************

using UnityEngine;

public class RankSetting : MonoBehaviour
{
    // 変数
    private SpriteRenderer MainSpriteRenderer;

    // それぞれのランクのテクスチャ
    [SerializeField] private Sprite Rank1Sprite;
    [SerializeField] private Sprite Rank2Sprite;
    [SerializeField] private Sprite Rank3Sprite;

    // それぞれのランクのスコア定義
    [SerializeField] private int nRank1Score;
    [SerializeField] private int nRank2Score;
    [SerializeField] private int nRank3Score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // このobjectのSpriteRendererを取得
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //=========================================================
    // ランク設定
    //=========================================================
    public void SetRank(int nScore)
    {
        // それぞれのスコアに合わせてテクスチャ変更
        if(nRank1Score <= nScore)
        {
            MainSpriteRenderer.sprite = Rank1Sprite;
        }
        else if(nRank2Score <= nScore)
        {
            MainSpriteRenderer.sprite = Rank2Sprite;
        }
        else if (nRank3Score <= nScore)
        {
            MainSpriteRenderer.sprite = Rank3Sprite;
        }
    }
}
