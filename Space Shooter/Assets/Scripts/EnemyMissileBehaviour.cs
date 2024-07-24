using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMissile : MonoBehaviour
{
    public float speed;


    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.down);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);

            if (collision.gameObject.CompareTag("Player"))
                Destroy(this.gameObject);

        }
    }

}
