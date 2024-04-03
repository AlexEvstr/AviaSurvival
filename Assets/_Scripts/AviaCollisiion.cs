using System.Collections;
using UnityEngine;

public class AviaCollisiion : MonoBehaviour
{
    [SerializeField] private FuelSpawnManager _manager;
    [SerializeField] private GameObject _losePanel;

    private void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(WaitBeforeStart());
    }

    private IEnumerator WaitBeforeStart()
    {
        gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<PolygonCollider2D>().enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fuel"))
        {
            Destroy(collision.gameObject);
            _manager.SpawnFuel();
            FuelCount.Fuel++;
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            _losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}