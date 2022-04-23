using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Enemy[] enemies;

    private void Update()
    {
        foreach (Enemy Enemies in enemies)
        {
            if (Enemies != null)
            {
                return;
            }
        }
        Debug.Log("Move to next level");
    }

}
