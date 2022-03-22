using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("HomeBase", LoadSceneMode.Single);
    }

    public void Options()
    {
        SceneManager.LoadScene("Options" , LoadSceneMode.Single);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("exited game");
    }

    public void Accessibility()
    {
        SceneManager.LoadScene("Accessibility", LoadSceneMode.Single);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
