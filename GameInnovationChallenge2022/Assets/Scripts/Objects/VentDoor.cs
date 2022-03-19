using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VentDoor : MonoBehaviour, IInteractable
{

    public GameObject interactableObject;



    // Start is called before the first frame update
    void Start()
    {
        interactableObject = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        SceneManager.LoadScene("SkillTreeWeapons");
        Debug.Log("Loading skill tree weapons");
    }
}
