using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [SerializeField] private GameObject[] enemyobject;
    [SerializeField] private Renderer panelRenderer;
    [SerializeField] private float _spawntime;


    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _spawntime)
        {
            _timer = 0f;
            Spawn();
        }
    }

    private void Spawn()
    {
        if (enemyobject.Length == 0 || panelRenderer == null) return;
        Bounds b = panelRenderer.bounds;
        Vector3 pos = new Vector3(
            Random.Range(b.min.x, b.max.x),
            Random.Range(b.min.y, b.max.y),
            Random.Range(b.min.z, b.max.z)
            );

        int index = Random.Range(0, enemyobject.Length);
        Instantiate(enemyobject[index], pos, Quaternion.identity);
    }
}