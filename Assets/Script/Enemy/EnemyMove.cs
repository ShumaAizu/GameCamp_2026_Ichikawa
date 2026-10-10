using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float _enemyspeed;
    [SerializeField] private float _targetX;


    private Rigidbody2D rb;
    private bool _arrived;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (_arrived) return;
        if(transform.position.x <= _targetX)
        {
            _arrived = true;
            rb.linearVelocity = new Vector2(0f, rb.linearVelocity.y);
            return;
        }
        rb.linearVelocity = new Vector2(-_enemyspeed,rb.linearVelocity.y);
    }
}
