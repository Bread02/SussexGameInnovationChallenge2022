using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this class checks the Game Data to see what abilities the player has selected and applies them to scene
public class PlayerAbilityCheck : MonoBehaviour
{

   // [SerializeField] private GameDataManager gameDataManager;
    [SerializeField] private SkillTreeMaster skillTreeMaster;

    //weapon scripts
    [SerializeField] private PlayerBeamAttack playerBeamAttack;
    [SerializeField] private PlayerBeeSwarmAttack playerBeeSwarmAttack;
    [SerializeField] private PlayerGooseAttack playerGooseAttack;
    [SerializeField] private PlayerProjectileGun playerProjectileGun;


    // Start is called before the first frame update
    void Start()
    {
        if(skillTreeMaster.BoolPetRockSelected())
        {
            playerProjectileGun.enabled = true;
        }

        if(skillTreeMaster.BoolQuackAttackSelected())
        {
            playerGooseAttack.enabled = true;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
