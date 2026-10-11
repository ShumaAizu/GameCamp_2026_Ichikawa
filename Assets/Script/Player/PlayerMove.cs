using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _playerspeed;
    private Rigidbody2D rb;
    private InputAction _moveAction;
    [SerializeField] private float _maxposition;
    [SerializeField] private float _minposition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

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
    }

    private void FixedUpdate()
    {
        Vector2 pos = rb.position;
        pos.y = Mathf.Clamp(pos.y, _minposition, _maxposition);
        rb.position = pos;
    }

}
