using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Missile1 : MonoBehaviour
{
    public float speed;


    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector2.up);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);

            if (collision.gameObject.CompareTag("Enemy"))
                Destroy(this.gameObject);

        }
    }

}    