using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWeaponIcon : MonoBehaviour
{
    public Image weaponIconImage;
    public PlayerAbilityCheck playerAbilityCheck;

    [SerializeField] private Sprite duckAttackIcon;
    [SerializeField] private Sprite platypusBeamAttackIcon;
    [SerializeField] private Sprite beeAttackIcon;
    [SerializeField] private Sprite projectileAttackIcon;

    void Start()
    {
        //if duck attack selected then select that
        if (playerAbilityCheck.playerProjectileGun.enabled)
        {
            Debug.Log("Projectile attack sprite image");
            weaponIconImage.sprite = projectileAttackIcon;
        }

        if (playerAbilityCheck.playerGooseAttack.enabled)
        {
            Debug.Log("Goose attack sprite image");
            weaponIconImage.sprite = duckAttackIcon;
        }

        if(playerAbilityCheck.playerBeeSwarmAttack.enabled)
        {
            Debug.Log("Bee attack sprite image");
            weaponIconImage.sprite = beeAttackIcon;
        }

        if (playerAbilityCheck.playerBeamAttack.enabled)
        {
            Debug.Log("Beam attack sprite image");
            weaponIconImage.sprite = platypusBeamAttackIcon;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
