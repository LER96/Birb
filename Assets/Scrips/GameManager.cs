using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject[] enemies;
    private List<GameObject> countenemies;
    public Slingshot slinger;
    public void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject b in enemies)
        {
            countenemies.Add(b);
        }
    }

    private void Update()
    {
        if(countenemies.Count<=0)
        {
            //end menu(next lvl, restart, quit)
        }
        if(slinger.count<=0)
        {

        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LaunchGame()
    {
        SceneManager.LoadScene(1);
    }

}
