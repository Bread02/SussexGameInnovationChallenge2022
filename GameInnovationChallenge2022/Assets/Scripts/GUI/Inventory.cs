using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject playerProjectileGun;

    [SerializeField] public PlayerActionControls playerActionControls;
    public bool openInventory;


    private void Awake()
    {
        playerActionControls = new PlayerActionControls();

        playerActionControls.PlayerControls.Inventory.started += ctx => openInventory = true;
        playerActionControls.PlayerControls.Inventory.canceled += ctx => openInventory = false;

    }

    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();

    }

    public void Update()
    {
        if (openInventory == true)
        {
            Debug.Log("Inventory opened");
        }
    }

}
