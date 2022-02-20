using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    //(In old input) public KeyCode pauseKey;
    [SerializeField] public PlayerActionControls playerActionControls;

    //Ref:https://www.youtube.com/watch?v=HmXU4dZbaMw
    void Awake()
    {
        playerActionControls = new PlayerActionControls();
        playerActionControls.PlayerControls.Pause.started += ctx => isPaused = true;
        playerActionControls.PlayerControls.Pause.canceled += ctx => isPaused = false;
       
    }
    private void OnEnable()
    {
        playerActionControls.Enable();
    }
    private void OnDisable()
    {
        playerActionControls.Disable();
    }
    
    void Update()
    {
        if (isPaused == true)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        Debug.Log("Paused");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        SoundManager.PlaySound(SoundManager.Sound.MenuClick);
    }

    public void ResumeGame()
    {
        Debug.Log("UnPaused");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        SoundManager.PlaySound(SoundManager.Sound.MenuClick);
    }

    public void GoMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
