using UnityEngine;

public class BackGroundSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _backobj;
    [SerializeField] private float _intrval;
    [SerializeField] private Transform _spawnpoint;
    private float _timer;
    void Update()
    {
        _timer += Time.deltaTime;
        if(_timer >= _intrval)
        {
            Instantiate(_backobj, _spawnpoint.position, Quaternion.identity);
            _timer = 0;
        }
    }
}
