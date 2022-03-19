using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeBaseSceneManager : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        SceneManager.LoadScene("BiomeOne");
        Debug.Log("Loading Biome One");
    }
}
