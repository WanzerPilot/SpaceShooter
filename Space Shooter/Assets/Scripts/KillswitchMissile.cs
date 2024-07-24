using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DestroyOnTrigger2D : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.transform.parent.gameObject);
    }
}

