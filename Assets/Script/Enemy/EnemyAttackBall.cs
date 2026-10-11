using UnityEngine;

public class EnemyAttackBall : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
