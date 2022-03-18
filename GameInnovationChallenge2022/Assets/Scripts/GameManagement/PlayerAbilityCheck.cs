using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this class checks the Game Data to see what abilities the player has selected and applies them to scene. This script is attached to the player.
public class PlayerAbilityCheck : MonoBehaviour
{

    [SerializeField] private GameDataManager gameDataManager;

    //weapon scripts
    [SerializeField] public PlayerBeamAttack playerBeamAttack;
    [SerializeField] public PlayerBeeSwarmAttack playerBeeSwarmAttack;
    [SerializeField] public PlayerGooseAttack playerGooseAttack;
    [SerializeField] public PlayerProjectileGun playerProjectileGun;


    // All abilities are set to false by default
    void Start()
    {
        playerProjectileGun.enabled = false;
        playerGooseAttack.enabled = false;
        playerBeeSwarmAttack.enabled = false;
        playerBeamAttack.enabled = false;
        SelectedWeapon();
    }

    // Abilities are enabled depending whether they are 'true' in the game data manager
    void SelectedWeapon()
    {
        if(gameDataManager.SelectedWeapon() == 0)
        {
            playerProjectileGun.enabled = true;
            SelectedProjectileGunUpgrades();
        }
        if (gameDataManager.SelectedWeapon() == 1)
        {
            playerBeamAttack.enabled = true;
            SelectedBeamAttackUpgrades();
        }
        if (gameDataManager.SelectedWeapon() == 2)
        {
            playerGooseAttack.enabled = true;
            SelectedGooseAttackUpgrades();
        }
        if(gameDataManager.SelectedWeapon() == 3)
        {
            playerBeeSwarmAttack.enabled = true;
            SelectedBeeSwarmUpgrades();
        }
    }
    
    // Work in progress
    void SelectedProjectileGunUpgrades()
    {

    }

    void SelectedBeamAttackUpgrades()
    {

    }

    void SelectedGooseAttackUpgrades()
    {

    }

    void SelectedBeeSwarmUpgrades()
    {

    }
}
