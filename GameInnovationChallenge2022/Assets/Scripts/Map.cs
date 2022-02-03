using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    [SerializeField] public PlayerActionControls playerActionControls;
     public bool openMap;


    private void Awake()
    {
        playerActionControls = new PlayerActionControls();

        playerActionControls.PlayerControls.Map.started += ctx => openMap = true;
        playerActionControls.PlayerControls.Map.canceled += ctx => openMap = false;

    }

    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (openMap == true)
        {
            Debug.Log("Map opened");
        }
    }
}
