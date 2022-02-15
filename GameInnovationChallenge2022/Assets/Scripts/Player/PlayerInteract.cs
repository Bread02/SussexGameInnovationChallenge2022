using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour, IInteractable
{
    [SerializeField] private PlayerActionControls playerActionControls;

    [SerializeField] private List<GameObject> interactableGameObjects;
    private GameObject player;
    public GameObject interactQuestionMark;

    [SerializeField] private float interactDistance;

    public bool inRange;

    

    private bool interact;
    private void Awake()
    {
        player = this.gameObject;
        playerActionControls = new PlayerActionControls();

        playerActionControls.PlayerControls.Interact.started += ctx => interact = true;
        playerActionControls.PlayerControls.Interact.canceled += ctx => interact = false;

        interactQuestionMark.SetActive(false);
    }

    private void OnEnable()
    {
        playerActionControls.Enable();

    }

    private void OnDisable()
    {
        playerActionControls.Disable();

    }

    private void Update()
    {
            if (interact == true)
        {
            Interact();
            Debug.Log("Interacting with object");
        }
        
    }

    public void Interact()
    {
        foreach (var interactableGameObject in interactableGameObjects)
        {
            var interactable = interactableGameObject.GetComponent<IInteractable>();
            if (interactable == null) continue;
        //    Debug.Log(Vector2.Distance(player.transform.position, interactableGameObject.transform.position));
            if (Vector2.Distance(player.transform.position, interactableGameObject.transform.position) < interactDistance)
            {
                interactable.Interact();
                interactQuestionMark.SetActive(false);
            }
        }
    }
}
