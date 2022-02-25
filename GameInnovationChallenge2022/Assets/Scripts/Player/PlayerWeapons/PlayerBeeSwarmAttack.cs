using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// work in progress weapon
public class PlayerBeeSwarmAttack : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private GameObject beeSwarm;
    [SerializeField] private bool fire;
    [SerializeField] private PlayerActionControls playerActionControls;




    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        playerActionControls = new PlayerActionControls();

        playerActionControls.PlayerControls.PlayerFireWeapon.performed += ctx => fire = true;
        playerActionControls.PlayerControls.PlayerFireWeapon.canceled += ctx => fire = false;
        beeSwarm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FindEnemy()
    {

    }

    void AttackEnemy()
    {

    }

    void MoveTowardEnemy()
    {

    }
}
