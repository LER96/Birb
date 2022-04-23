using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bird"))
        {
            Destroy(gameObject);
        }
        else if (collision.contacts[0].normal.y < 0.5)
        {
            Destroy(gameObject);
        }
    } 
}
