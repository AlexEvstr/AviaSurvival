using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemies;

    private void Start()
    {
        SpawnEmenies();
    }

    private void SpawnEmenies()
    {
        for (int i = 0; i < _enemies.Length; i++)
        {
            GameObject newEnemy = Instantiate(_enemies[i]);
            int randomPositionX = Random.Range(-7, 7);
            int randomPositionY = Random.Range(-4, 4);
            Vector3 enemyPosition = new Vector3(randomPositionX, randomPositionY, 0);
            GameObject fuel = Instantiate(_enemies[i], enemyPosition, transform.rotation * Quaternion.Euler(0, 0, Random.Range(0, 180)));
        }
    }
}
