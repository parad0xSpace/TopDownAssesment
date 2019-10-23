using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
