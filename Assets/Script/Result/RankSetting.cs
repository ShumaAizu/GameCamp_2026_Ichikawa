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

    //=========================================================
    // 初期設定
    //=========================================================
    void Start()
    {
        // このobjectのSpriteRendererを取得
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        Debug.Log("a");
    }

    //=========================================================
    // 更新
    //=========================================================
    void Update()
    {
        
    }

    //=========================================================
    // ランク設定
    //=========================================================
    public void SetRank(int nScore)
    {
        Debug.Log(nScore);

        // それぞれのスコアに合わせてテクスチャ変更
        if(nRank1Score <= nScore)
        {// 一番上のランク
            MainSpriteRenderer.sprite = Rank1Sprite;
        }
        else if(nRank2Score <= nScore)
        {// 真ん中のランク
            MainSpriteRenderer.sprite = Rank2Sprite;
        }
        else if (nRank3Score <= nScore)
        {// 一番下のランク
            MainSpriteRenderer.sprite = Rank3Sprite;
        }
    }
}
