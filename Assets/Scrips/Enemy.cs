using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP=1;
    private bool alive = true;
    // Update is called once per frame
    void Update()
    {
        if(!alive)
        {
            Destroy(this.gameObject);
        }
    }

    private bool IsAlive()
    {
        if (HP > 0)
        {
            return alive = true;
        }
        else
            return alive = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            alive = false;
        }
    }
}
