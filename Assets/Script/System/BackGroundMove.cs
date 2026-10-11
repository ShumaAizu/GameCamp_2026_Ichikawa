using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _destroyx;

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime, Space.World);
        if(transform.position.x <= _destroyx)
        {
            Destroy(gameObject);
        }
    }
}
