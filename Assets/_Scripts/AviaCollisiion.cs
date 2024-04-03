using UnityEngine;

public class AviaCollisiion : MonoBehaviour
{
    [SerializeField] private FuelSpawnManager _manager;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fuel"))
        {
            Destroy(collision.gameObject);
            _manager.SpawnFuel();
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game over");
            Time.timeScale = 0;
        }
    }
}