using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject wincanvas;
    public GameObject losecanvas;
    public GameObject slinger;
    public GameObject enemyHold;
    Slingshot s;
    WinCondition hold;
    public void Start()
    {
        losecanvas.SetActive(false);
        wincanvas.SetActive(false);
        s = slinger.GetComponent<Slingshot>();
        hold = enemyHold.GetComponent<WinCondition>();
    }

    private void Update()
    {
        if(s.count<=0 && hold.check)
        {
            losecanvas.SetActive(true);
            Time.timeScale = 0;
        }
        if(hold.check==false && s.count>0)
        {
            wincanvas.SetActive(true);
            Time.timeScale = 0;
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
