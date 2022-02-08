using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    [SerializeField] public PlayerActionControls playerActionControls;
    public static bool pause;
    public GameObject pauseScreen;

    // Start is called before the first frame update
    void Awake()
    {
        playerActionControls = new PlayerActionControls();

        playerActionControls.PlayerControls.Pause.started += ctx => pause = true;
        playerActionControls.PlayerControls.Pause.canceled += ctx => pause = false;
    }
    private void OnEnable()
    {
        playerActionControls.Enable();

    }

    private void OnDisable()
    {
        playerActionControls.Disable();

    }

    // Update is called once per frame
    void Update()
    {
        if (pause == true)
        {
            Time.timeScale = 0;
            Debug.Log("Game paused");
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
