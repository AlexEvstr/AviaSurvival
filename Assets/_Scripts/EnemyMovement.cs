using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float _enemySpeed = 3.0f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _enemySpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            transform.Rotate(180, 0, 0);
        } 
    }
}