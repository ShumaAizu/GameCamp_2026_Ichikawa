using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private GameObject _enemyball;
    [SerializeField] private float _interval;
    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;
        if( _timer >= _interval)
        {
            _timer = 0;
            Instantiate(_enemyball, transform.position, Quaternion.identity);
        }
    }
}
