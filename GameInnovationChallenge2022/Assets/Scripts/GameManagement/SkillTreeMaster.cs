using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this class controls the skill tree.
// It will check whether a player has point(s) they can spend.
// it will let the player buy an ability if they have the points.
// if item is bought, button is replaced with a select button.
public class SkillTreeMaster : MonoBehaviour
{
    public int skillPoints;
    public GameDataManager gameDataManager;

    public GameObject petRockButtonBuy;
    public GameObject petRockButtonUnlocked;

    public GameObject ShatterShotButtonBuy;
    public GameObject ShatterShotButtonUnlocked;

    public GameObject VolcanicButtonBuy;
    public GameObject VolcanicButtonUnlocked;

    public GameObject LavaButtonBuy;
    public GameObject LavaButtonUnlocked;

    public GameObject quackAttackBuy;
    public GameObject quackAttackUnlocked;

    public bool PetRockSelected;
    public bool QuackAttackSelected;
    //  public bool ShatterShotSelected;
    //   public bool VSelected;
    //  public bool PetRockSelected;

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

        if (gameDataManager.shatterShot == false)
        {
            ShatterShotButtonBuy.SetActive(true);
            ShatterShotButtonUnlocked.SetActive(false);
        }
        else
        {
            ShatterShotButtonBuy.SetActive(false);
            ShatterShotButtonUnlocked.SetActive(true);
        }

        if (gameDataManager.volcanic == false)
        {
            VolcanicButtonBuy.SetActive(true);
            VolcanicButtonUnlocked.SetActive(false);
        }
        else
        {
            VolcanicButtonBuy.SetActive(false);
            VolcanicButtonUnlocked.SetActive(true);
        }

        if (gameDataManager.volcanic == false)
        {
            LavaButtonBuy.SetActive(true);
            LavaButtonUnlocked.SetActive(false);
        }
        else
        {
            LavaButtonBuy.SetActive(false);
            LavaButtonUnlocked.SetActive(true);
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

    // sets pet rock to true and all other weapons to false
    public void SelectPetRock()
    {
        // pet rock equipped
        PetRockSelected = true;
        UnselectQuackAttack();
        Debug.Log("Rock attack selected");
      //  petRockButtonUnlocked.GetComponent<Image>().color = Color.magenta;
        Button b = petRockButtonUnlocked.GetComponent<Button>();
        ColorBlock cb = b.colors;
        cb.normalColor = Color.magenta;
        b.colors = cb;
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
