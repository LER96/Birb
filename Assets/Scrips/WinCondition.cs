using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Enemy[] enemies;
    public GameObject winCanvas;
    private void Update()
    {
        foreach (Enemy Enemies in enemies)
        {
            if (Enemies != null)
            {
                return;
            }
        }
        winCanvas.SetActive(true);
    }

}
