using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class EnemyChange : MonoBehaviour
{
    [SerializeField] private Sprite _nextSprite;
    [SerializeField] private GameObject _lockimage;
    [SerializeField] private float _waittime;
    [SerializeField] private float _fadetime;
    private ScoreDisplay _scoreDisplay;
    private SpriteRenderer _spriteRenderer;
    private int _crickcount = 0;
    private Animator _playeranimator;
    private int _enemyscore = 300;
    private int _itemscore = 100;
    private int GetScoreByTag()
    {
        if (CompareTag("Enemy"))
        {
            return _enemyscore;
        }
        else
        {
            return _itemscore;
        }
    }
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
        if (gameObject != null)
        {
            _playeranimator = gameObject.GetComponent<Animator>();
        }
        GameObject _scoreObj = GameObject.Find("ScoreText");
        if( _scoreObj != null)
        {
            _scoreDisplay = _scoreObj.GetComponent<ScoreDisplay>();
        }


        if(_lockimage  != null)
        {
            _lockimage.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        _crickcount++;

        if(_crickcount == 1)
        {
            if(_lockimage != null)
            {
                _lockimage.SetActive(true);
            }
        }
        else if(_crickcount == 2)
        {
            if (_nextSprite != null && _spriteRenderer != null)
            {
                _spriteRenderer.sprite = _nextSprite;
                if( _scoreDisplay != null)
                {
                    _scoreDisplay.AddScore(GetScoreByTag());
                }
            }
            if( _lockimage != null)
            {
                _lockimage.SetActive(false);
            }
            if(_playeranimator != null)
            {
                _playeranimator.Play("PlayerAttackAnimation");
            }
            StartCoroutine(FadeAndDestroy());
        }
    }
    private IEnumerator FadeAndDestroy()
    {
        yield return new WaitForSeconds(_waittime);
        if (_spriteRenderer != null)
        {
            Color color = _spriteRenderer.color;
            float elapsed = 0f;

            while (elapsed < _fadetime)
            {
                elapsed += Time.deltaTime;
                color.a = Mathf.Lerp(1f,0f,elapsed / _fadetime);
                _spriteRenderer.color = color;
                yield return null;
            }
        }
        Destroy(gameObject);
    }
}