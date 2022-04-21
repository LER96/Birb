using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP=1;

    // Update is called once per frame
    void Update()
    {
        if(!IsAlive())
        {
            Destroy(this.gameObject);
        }
    }

    private bool IsAlive()
    {
        if (HP > 0)
        {
            return true;
        }
        else
            return false;
    }
}
