using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Enemy[] enemies;
    //public GameObject winCanvas;
    public bool check;
    private void Update()
    {
        foreach (Enemy Enemies in enemies)
        {
            if (Enemies != null)
            {
                check = true;
                return;
            }
        }
        check = false;
        //winCanvas.SetActive(true);
    }

}
