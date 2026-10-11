using UnityEngine;
using System.Collections;
using System.Collections.Concurrent;

public class PlayerHit : MonoBehaviour
{
    [SerializeField] private ScoreDisplay _scoreDisplay;
    private int _hitenemy = -100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _scoreDisplay.AddScore(_hitenemy);
        }
    }
}
