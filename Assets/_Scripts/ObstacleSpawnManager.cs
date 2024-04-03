using UnityEngine;

public class ObstacleSpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _obstacle;

    private void Awake()
    {
        SpawnObstacles();
    }

    private void SpawnObstacles()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject newObstacle = Instantiate(_obstacle);
            float randomX = Random.Range(-8f, 8f);
            float randomY = Random.Range(-4f, 4f);
            newObstacle.transform.position = new Vector2(randomX, randomY);
        }
    }
}