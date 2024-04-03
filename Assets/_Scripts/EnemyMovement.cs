using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float _enemySpeed = 10.0f;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _enemySpeed);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
    //    transform.Rotate(180, 0, 0);
    //    gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            transform.Rotate(180, 0, 0);
        }
        
    }
}
