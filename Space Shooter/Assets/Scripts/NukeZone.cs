using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DestroyCollider2D : MonoBehaviour
{
    //Detect collisions between the GameObjects with Colliders attached
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.parent.CompareTag("Missile"))
            Destroy(transform.parent.gameObject);

    }
    }
