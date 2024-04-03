using UnityEngine;

public class PlaneController : MonoBehaviour
{
    private float _speed = 5.0f;
    private float _rotationSpeed = 5;
    public FixedJoystick fixJS;
    public Rigidbody2D rb;

    public void FixedUpdate()
    {
        Vector2 direction = Vector2.up * fixJS.Vertical + Vector2.right * fixJS.Horizontal;

        float inputMagnitude = Mathf.Clamp01(direction.magnitude);
        direction.Normalize();

        transform.Translate(direction * _speed * inputMagnitude * Time.deltaTime, Space.World);

        if (direction != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _rotationSpeed );
        }
    }
}