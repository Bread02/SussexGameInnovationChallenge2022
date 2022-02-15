using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this class checks the Game Data to see what abilities the player has selected and applies them to scene
public class PlayerAbilityCheck : MonoBehaviour
{

    [SerializeField] private GameDataManager gameDataManager;


    //weapon scripts
    [SerializeField] private PlayerBeamAttack playerBeamAttack;
    [SerializeField] private PlayerBeeSwarmAttack playerBeeSwarmAttack;
    [SerializeField] private PlayerGooseAttack playerGooseAttack;
    [SerializeField] private PlayerProjectileGun playerProjectileGun;


    // Start is called before the first frame update
    void Start()
    {
        playerProjectileGun.enabled = false;
        playerGooseAttack.enabled = false;
        playerBeeSwarmAttack.enabled = false;
        playerBeamAttack.enabled = false;
        SelectedWeapon();
    }

    void SelectedWeapon()
    {
        if(gameDataManager.SelectedWeapon() == 0)
        {
            playerProjectileGun.enabled = true;
        }
        if (gameDataManager.SelectedWeapon() == 1)
        {
            playerBeamAttack.enabled = true;
        }
        if (gameDataManager.SelectedWeapon() == 2)
        {
            playerGooseAttack.enabled = true;
        }
        if(gameDataManager.SelectedWeapon() == 3)
        {
            playerBeeSwarmAttack.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
