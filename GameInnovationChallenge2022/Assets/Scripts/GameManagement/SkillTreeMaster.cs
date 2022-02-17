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
    [SerializeField] private GameObject beeAttackUnlock;

    [SerializeField] private GameObject beeAttackHoneyBuy;
    [SerializeField] private GameObject beeAttackHoneyUnlock;

    [SerializeField] private GameObject beeAttackPoisonStingBuy;
    [SerializeField] private GameObject beeAttackPoisonStingUnlock;

    [SerializeField] private GameObject beeAttackQueenBeeBuy;
    [SerializeField] private GameObject beeAttackQueenBeeUnlock;
    #endregion

    // Selections
    public bool PetRockSelected;


    public bool QuackAttackSelected;

    public TMP_Text textTitle;
    public TMP_Text textDescription;

    public Button button;

    // Start is called before the first frame update
    void Start()
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

        if (gameDataManager.petRockVolcanic == false)
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

    }

    // Update is called once per frame
    void Update()
    {

    }

    #region Unlock Buttons
    public void UnlockPetRock()
    {
        Debug.Log("CLICK");
        if(gameDataManager.skillPoints > 0)
        {
            gameDataManager.petRock = true;
            petRockButtonBuy.SetActive(false);
            petRockButtonUnlocked.SetActive(true);
            Debug.Log("Pet Rock Unlocked");
        }
    }


    public void UnlockQuackAttack()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.quackAttack = true;
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
            Debug.Log("Quack Attack Unlocked");
        }
    }

    // Platypus Beam Unlocks
    public void UnlockPlatypusBeam()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.quackAttack = true;
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
            Debug.Log("Quack Attack Unlocked");
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
            Debug.Log("Platypus Beam Fire Unlocked");
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
            Debug.Log("Platypus Beam Freeze Unlocked");
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
            Debug.Log("Platypus Beam Fire Unlocked");
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
            Debug.Log("Platypus Beam Fire Unlocked");
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
            Debug.Log("Platypus Beam Fire Unlocked");
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
            Debug.Log("Platypus Beam Fire Unlocked");
        }
    }




    public void UnlockBeeAttack()
    {
        Debug.Log("CLICK");
        if (gameDataManager.skillPoints > 0)
        {
            gameDataManager.quackAttack = true;
            quackAttackBuy.SetActive(false);
            quackAttackUnlocked.SetActive(true);
            Debug.Log("Quack Attack Unlocked");
        }
    }

    #endregion

    // sets pet rock to true and all other weapons to false
    public void SelectPetRock()
    {
        PetRockSelected = true;
        UnselectQuackAttack();
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


}
