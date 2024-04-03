using UnityEngine;

public class FuelBonusMovement : MonoBehaviour
{
    private float _fuelSpeed = 2.0f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _fuelSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.Rotate(180, 0, 0);
    }
}