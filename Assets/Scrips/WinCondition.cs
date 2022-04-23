using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Enemy[] enemies;
    //public GameObject winCanvas;
    public bool check;

    private void Start()
    {
        check = false;
    }
    private void Update()
    {
        foreach (Enemy Enemies in enemies)
        {
            if (Enemies != null)
            {
                check = true;
                return;
            }
            else
            {
                check = false;
            }
        }
        //check = false;
        //winCanvas.SetActive(true);
    }

}
