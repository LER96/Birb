using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LaunchGame()
    {
        SceneManager.LoadScene(1);
    }

}
