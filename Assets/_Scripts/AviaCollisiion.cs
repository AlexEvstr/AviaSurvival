using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaCollisiion : MonoBehaviour
{
    [SerializeField] private FuelSpawnManager _manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fuel"))
        {
            Destroy(collision.gameObject);
            //Destroy(collision.transform.parent.gameObject);
            _manager.SpawnFuel();
        }
    }
}