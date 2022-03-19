using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeBaseSceneManager : MonoBehaviour, IInteractable
{

    private GameObject biomeOneSquare;

    // Start is called before the first frame update
    void Start()
    {
        biomeOneSquare = this.gameObject;
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
