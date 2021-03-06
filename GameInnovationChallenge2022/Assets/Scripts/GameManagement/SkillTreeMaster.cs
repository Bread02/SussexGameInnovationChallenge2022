using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// this class controls the skill tree.
// It will check whether a player has point(s) they can spend.
// it will let the player buy an ability if they have the points.
// if item is bought, button is replaced with a select button.
public class SkillTreeMaster : MonoBehaviour
{
    public int skillPoints;
    public int unlockedAbilityAndWeaponCount;
    [SerializeField] private GameDataManager gameDataManager;

    #region Buttons
    // pet rock and abilities
    [SerializeField] private GameObject petRockButtonBuy;
    [SerializeField] private GameObject petRockButtonUnlocked;

    [SerializeField] private GameObject petRockShatterShotButtonBuy;
    [SerializeField] private GameObject petRockShatterShotButtonUnlocked;

    [SerializeField] private GameObject petRockVolcanicButtonBuy;
    [SerializeField] private GameObject petRockVolcanicButtonUnlocked;

    [SerializeField] private GameObject petRockLavaButtonBuy;
    [SerializeField] private GameObject petRockLavaButtonUnlocked;

    // quack attack and abilities
    [SerializeField] private GameObject quackAttackBuy;
    [SerializeField] private GameObject quackAttackUnlocked;

    [SerializeField] private GameObject quackAttackEchoBuy;
    [SerializeField] private GameObject quackAttackEchoUnlocked;

    [SerializeField] private GameObject quackAttackRazeBuy;
    [SerializeField] private GameObject quackAttackRazeUnlocked;

    [SerializeField] private GameObject quackAttackFeatherBuy;
    [SerializeField] private GameObject quackAttackFeatherUnlocked;

    // Platypus beam and abilities
    [SerializeField] private GameObject platypusBeamBuy;
    [SerializeField] private GameObject platypusBeamUnlocked;

    [SerializeField] private GameObject platypusBeamFireBuy;
    [SerializeField] private GameObject platypusBeamFireUnlocked;

    [SerializeField] private GameObject platypusBeamFreezeBuy;
    [SerializeField] private GameObject platypusBeamFreezeUnlocked;

    [SerializeField] private GameObject platypusBeamExplodeBuy;
    [SerializeField] private GameObject platypusBeamExplodeUnlocked;

    [SerializeField] private GameObject platypusBeamDeepFreezeBuy;
    [SerializeField] private GameObject platypusBeamDeepFreezeUnlocked;

    [SerializeField] private GameObject platypusBeamTwinBeamBuy;
    [SerializeField] private GameObject platypusBeamTwinBeamUnlocked;

    // Bee attacks and abilities
    [SerializeField] private GameObject beeAttackBuy;
    [SerializeField] private GameObject beeAttackUnlocked;

    [SerializeField] private GameObject beeAttackHoneyBuy;
    [SerializeField] private GameObject beeAttackHoneyUnlocked;

    [SerializeField] private GameObject beeAttackPoisonStingBuy;
    [SerializeField] private GameObject beeAttackPoisonStingUnlocked;

    [SerializeField] private GameObject beeAttackQueenBeeBuy;
    [SerializeField] private GameObject beeAttackQueenBeeUnlocked;
    #endregion

    // Selections
    public bool PetRockSelected;
    public bool platypusBeamSelected;
    public bool beeAttackSelected;
    public bool QuackAttackSelected;

    // the item name and description
    public TMP_Text textTitle;
    public TMP_Text textDescription;

    // Start is called before the first frame update
    void Update()
    {
        if(gameDataManager.petRock == false)
        {
            petRockButtonBuy.SetActive(true);
            petRockButtonUnlocked.SetActive(false);
        }
        else
        {
            petRockButtonBuy.SetActive(false);
            petRockButtonUnlocked.SetActive(true);
        }

        if (gameDataManager.petRockShatterShot == false)
        {
            petRockShatterShotButtonBuy.SetActive(true);
            petRockShatterShotButtonUnlocked.SetActive(false);
        }
        else
        {
            petRockShatterShotButtonBuy.SetActive(false);
            petRockShatterShotButtonUnlocked.SetActive(true);
        }

        if (gameDataManager.petRockVolcanic == false)
        {
            petRockVolcanicButtonBuy.SetActive(true);
            petRockVolcanicButtonUnlocked.SetActive(false);
        }
        else
        {
            petRockVolcanicButtonBuy.SetActive(false);
            petRockVolcanicButtonUnlocked.SetActive(true);
        }

        if (gameDataManager.petRockLava == false)
        {
            petRockLavaButtonBuy.SetActive(true);
            petRockLavaButtonUnlocked.SetActive(false);
        }
        else
        {
            petRockLavaButtonBuy.SetActive(false);
            petRockLavaButtonUnlocked.SetActive(true);
        }

        if (gameDataManager.quackAttack == false)
        {
            quackAttackBuy.SetActive(true);
            quackAttackUnlocked.SetActive(false);
        }
        else
        {
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
        }
        if(gameDataManager.quackAttackEcho == false)
        {
            quackAttackEchoBuy.SetActive(true);
            quackAttackEchoUnlocked.SetActive(false);
        }

        if (gameDataManager.quackAttackRaze == false)
        {
            quackAttackRazeBuy.SetActive(true);
            quackAttackRazeUnlocked.SetActive(false);
        }

        if (gameDataManager.quackAttackFeather == false)
        {
            quackAttackFeatherBuy.SetActive(true);
            quackAttackFeatherUnlocked.SetActive(false);
        }

        if (gameDataManager.beeAttack == false)
        {
            beeAttackBuy.SetActive(true);
            beeAttackUnlocked.SetActive(false);
        }
        
        if (gameDataManager.beeAttackHoney == false)
        {
            beeAttackHoneyBuy.SetActive(true);
            beeAttackHoneyUnlocked.SetActive(false);
        }

        if(gameDataManager.beeAttackPoisonSting == false)
        {
            beeAttackPoisonStingBuy.SetActive(true);
            beeAttackPoisonStingUnlocked.SetActive(false);
        }

        if(gameDataManager.beeAttackQueenBee == false)
        {
            beeAttackPoisonStingBuy.SetActive(true);
            beeAttackPoisonStingUnlocked.SetActive(false);
        }
    }

    #region Unlock Buttons

    #region Pet Rock Unlock Buttons
    // pet rock unlocks
    public void UnlockPetRock()
    {
        Debug.Log("CLICK");
        if(gameDataManager.skillPoints > 0)
        {
            gameDataManager.petRock = true;
            petRockButtonBuy.SetActive(false);
            petRockButtonUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }

    public void UnlockPetRockShatterShot()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.petRockShatterShot = true;
            petRockButtonBuy.SetActive(false);
            petRockButtonUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }

    public void UnlockPetRockVolcanic()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.petRockVolcanic = true;
            petRockButtonBuy.SetActive(false);
            petRockButtonUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }

    public void UnlockPetRockLava()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.petRockLava = true;
            petRockButtonBuy.SetActive(false);
            petRockButtonUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }

    #endregion

    #region Quack Attack Unlock Buttons
    public void UnlockQuackAttack()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.quackAttack = true;
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }

    public void UnlockQuackAttackEcho()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.quackAttackEcho = true;
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }

    public void UnlockQuackAttackRaze()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.quackAttackRaze = true;
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }

    public void UnlockQuackAttackFeather()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.quackAttackFeather = true;
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }
    #endregion

    #region Platypus Unlock Buttons
    // Platypus Beam Unlocks
    public void UnlockPlatypusBeam()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.platypusBeam = true;
            platypusBeamBuy.SetActive(false);
            platypusBeamUnlocked.SetActive(true);
        }
    }

    public void UnlockPlatypusBeamFire()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.platypusBeamFire = true;
            platypusBeamFireBuy.SetActive(false);
            platypusBeamFireUnlocked.SetActive(true);
        }
    }

    public void UnlockPlatypusBeamFreeze()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.platypusBeamFreeze = true;
            platypusBeamFreezeBuy.SetActive(false);
            platypusBeamFreezeUnlocked.SetActive(true);
        }
    }

    public void UnlockPlatypusBeamExplode()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.platypusBeamExplode = true;
            platypusBeamFireBuy.SetActive(false);
            platypusBeamFireUnlocked.SetActive(true);
        }
    }

    public void UnlockPlatypusBeamDeepFreeze()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.platypusBeamDeepFreeze = true;
            platypusBeamFireBuy.SetActive(false);
            platypusBeamFireUnlocked.SetActive(true);
        }
    }

    public void UnlockPlatypusBeamTwinBeam()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.platypusBeamTwinBeam = true;
            platypusBeamFireBuy.SetActive(false);
            platypusBeamFireUnlocked.SetActive(true);
        }
    }
    #endregion

    #region Bee Attack Unlock Buttons
    public void UnlockBeeAttack()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.beeAttack = true;
            beeAttackBuy.SetActive(false);
            beeAttackUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }

    public void UnlockBeeAttackHoney()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.beeAttackHoney = true;
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }

    public void UnlockBeeAttackPoisonSting()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.beeAttackPoisonSting = true;
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }

    public void UnlockBeeAttackQueenBee()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.beeAttackQueenBee = true;
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
            unlockedAbilityAndWeaponCount++;
        }
    }
    #endregion

    #endregion
    #region Select/unselect Buttons
    // sets pet rock to true and all other weapons to false
    public void SelectPetRock()
    {
        PetRockSelected = true;
        UnselectQuackAttack();
        UnselectBeeAttack();
        UnselectPlatypusBeamAttack();
        Debug.Log("Rock attack selected");
        Button b = petRockButtonUnlocked.GetComponent<Button>();
        // button color changes when selected
        ColorBlock cb = b.colors;
        cb.normalColor = Color.magenta;
        b.colors = cb;
        // choose the text displayed when item is selected
        textTitle.text = "Pet Rock";
        textDescription.text = "Fires a projectile";
    }


    public void UnselectPetRock()
    {
        PetRockSelected = true;
        Button b = petRockButtonUnlocked.GetComponent<Button>();
        ColorBlock cb = b.colors;
        cb.normalColor = Color.green;
        b.colors = cb;
    }

    public bool BoolPetRockSelected()
    {
        if (PetRockSelected == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SelectQuackAttack()
    {
        PetRockSelected = false;
        QuackAttackSelected = true;
        Debug.Log("Quack attack selected");
        UnselectPetRock();
        UnselectBeeAttack();
        UnselectPlatypusBeamAttack();
        Button b = quackAttackUnlocked.GetComponent<Button>();
        ColorBlock cb = b.colors;
        cb.normalColor = Color.magenta;
        b.colors = cb;
    }

    public void UnselectQuackAttack()
    {
        QuackAttackSelected = false;
        Button b = quackAttackUnlocked.GetComponent<Button>();
        ColorBlock cb = b.colors;
        cb.normalColor = Color.green;
        b.colors = cb;
    }

    public bool BoolQuackAttackSelected()
    {
        if (QuackAttackSelected == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SelectPlatypusBeamAttack()
    {
        PetRockSelected = false;
        QuackAttackSelected = false;
        platypusBeamSelected = true;
        Debug.Log("Platypus Beam attack selected");
        UnselectPetRock();
        UnselectQuackAttack();
        UnselectBeeAttack();
        Button b = platypusBeamUnlocked.GetComponent<Button>();
        ColorBlock cb = b.colors;
        cb.normalColor = Color.magenta;
        b.colors = cb;
    }

    public void UnselectPlatypusBeamAttack()
    {
        platypusBeamSelected = false;
        Button b = platypusBeamUnlocked.GetComponent<Button>();
        ColorBlock cb = b.colors;
        cb.normalColor = Color.green;
        b.colors = cb;
    }

    public bool BoolPlatypusBeamSelected()
    {
        if (platypusBeamSelected == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SelectBeeAttack()
    {
        beeAttackSelected = true;
        Debug.Log("Platypus Beam attack selected");
        UnselectPetRock();
        UnselectQuackAttack();
        UnselectPlatypusBeamAttack();
        Button b = beeAttackUnlocked.GetComponent<Button>();
        ColorBlock cb = b.colors;
        cb.normalColor = Color.magenta;
        b.colors = cb;
    }

    public void UnselectBeeAttack()
    {
        beeAttackSelected = false;
        Button b = beeAttackUnlocked.GetComponent<Button>();
        ColorBlock cb = b.colors;
        cb.normalColor = Color.green;
        b.colors = cb;
    }

    public bool BoolBeeSelected()
    {
        if (beeAttackSelected == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    #endregion


}
