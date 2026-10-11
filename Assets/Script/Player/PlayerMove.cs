using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _playerspeed;
    [SerializeField] private float _maxposition;
    [SerializeField] private float _minposition;

    [SerializeField] private LayerMask _groundlayer;
    [SerializeField] float _raylength = 0.2f;
    [SerializeField] private Vector2 _rayoffset = Vector2.zero;
    private bool _isFlay;
    private Rigidbody2D rb;
    private Animator _playeranimator;
    private InputAction _moveAction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _playeranimator = GetComponent<Animator>();

        _moveAction = new InputAction("Move", InputActionType.Value, expectedControlType: "Axis");

        _moveAction.AddCompositeBinding("1DAxis")
            .With("Negative", "<Keyboard>/s")
            .With("Positive", "<Keyboard>/w");
    }
    private void OnEnable() => _moveAction.Enable();
    private void OnDisable() => _moveAction.Disable();
    private void Update()
    {
        float y = _moveAction.ReadValue<float>();
        rb.linearVelocity = new Vector2(rb.linearVelocity.x,  y * _playerspeed);

        //CheckGround();
    }

    private void CheckGround()
    {
        Vector2 orizin = (Vector2)transform.position + _rayoffset;
        RaycastHit2D hit = Physics2D.Raycast(orizin, Vector2.down, _raylength, _groundlayer);
        bool isGround = hit.collider != null;
        _isFlay = isGround;
        _playeranimator.SetBool("Isfly", _isFlay);

    }


    private void FixedUpdate()
    {
        Vector2 pos = rb.position;
        pos.y = Mathf.Clamp(pos.y, _minposition, _maxposition);
        rb.position = pos;
    }
}
