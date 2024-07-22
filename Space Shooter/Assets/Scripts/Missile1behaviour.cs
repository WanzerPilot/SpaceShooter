using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Missile1 : MonoBehaviour
{
    public float speed = 4.5f;


    private void Update()
    {
        transform.position += speed * Time.deltaTime * transform.up;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Missile1"))
        {
            Destroy(gameObject);
        }
    }
}