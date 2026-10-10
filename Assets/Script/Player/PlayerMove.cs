using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _playerspeed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }
    private void Update()
    {
        float y = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector2(rb.linearVelocity.x,  y * _playerspeed);
    }
}
