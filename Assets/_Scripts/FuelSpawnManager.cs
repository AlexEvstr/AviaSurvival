using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelSpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _fuel;

    private void Start()
    {
        SpawnFuel();
    }

    public void SpawnFuel()
    {
        StartCoroutine(WaitAndSpawn());
    }

    private IEnumerator WaitAndSpawn()
    {
        yield return new WaitForSeconds(0.5f);
        float randomPositionX = Random.Range(-7.5f, 7.5f);
        float randomPositionY = Random.Range(-3.5f, 3.5f);
        Vector3 fuelPosition = new Vector3(randomPositionX, randomPositionY, 0);

        GameObject fuel = Instantiate(_fuel, fuelPosition, transform.rotation * Quaternion.Euler(0, 0, Random.Range(0, 180)));
    }
}
