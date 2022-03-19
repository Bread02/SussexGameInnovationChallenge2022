using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkillTreeWeaponsSceneManager : MonoBehaviour
{

    [SerializeField] private Button backToHomeButton;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("HomeBase");
    }
}
