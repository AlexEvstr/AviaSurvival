using UnityEngine;

public class FuelBonusMovement : MonoBehaviour
{
    private float _fuelSpeed = 2.0f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _fuelSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Obstacle") && !collision.gameObject.CompareTag("Enemy"))
        {
            transform.Rotate(180, 0, 0);
        }
    }
}