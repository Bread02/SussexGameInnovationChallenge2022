using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// keeps track of player inventory, points, skills, etc.
public class GameDataManager: MonoBehaviour
{
    public int skillPoints;
    private int timesDied;
    private GameDataManager gameDataManager;

    private void Awake()
    {
      //  DontDestroyOnLoad(this.gameObject);
    }

    // check whether player has these pet rock abilities unlocked
    public bool petRock;
    public bool shatterShot;
    public bool volcanic;
    public bool lava;

    // check whether player has these platypus abilities unlocked
    public bool platypusBeam;
    public bool fire;
    public bool freeze;
    public bool explode;
    public bool deepFreeze;
    public bool twinBeam;

    // check whether player has these quackAttack abilities unlocked
    public bool quackAttack;
    public bool echo;
    public bool raze;
    public bool feather;

    //check whether player has these bees abilities unlocked;
    public bool bees;
    public bool honey;
    public bool poisonSting;
    public bool queenBee;

    // check which weapon is selected
    public bool petRockSelected;
    public bool platypusBeamSelected;
    public bool quackAttackSelected;
    public bool beesSelected;


    public GameDataManager(int skillPoints, int timesDied, bool petRock,
        bool shatterShot, bool volcanic, bool lava)
    {
        this.skillPoints = skillPoints;
        this.timesDied = timesDied;
        this.petRock = petRock;
        this.shatterShot = shatterShot;
        this.volcanic = volcanic;
        this.lava = lava;
        return;
    }


    private void ReadFromSave()
    {
        //Load achievments
        string filePath = $"{Application.persistentDataPath}/Save/gameData.save";
        if (File.Exists(filePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filePath, FileMode.Open);

            string json = (string)formatter.Deserialize(stream);
            gameDataManager = JsonUtility.FromJson<GameDataManager>(json);

            stream.Close();
        }
        else
        {
            Debug.LogWarning($"gameData File not found");
        //    gameDataManager = new GameDataManager(0, 0, false, false, false, false);
        }
    }

    private void WriteToSave()
    {
        Debug.Log("Writing Player Save");

        BinaryFormatter formatter = new BinaryFormatter();
        /*CreateSaveDirectoryPaths();*/
        string filePath = $"{Application.persistentDataPath}/Save/gameData.save";
        FileStream stream = new FileStream(filePath, FileMode.Create);
        string json = JsonUtility.ToJson(gameDataManager);
        formatter.Serialize(stream, json);
        stream.Close();
        Debug.Log("Saved gameData.");

        /*
        filePath = $"{Application.persistentDataPath}/Save/endings.save";
        stream = new FileStream(filePath, FileMode.Create);
        string json2 = JsonUtility.ToJson(endingsUnlocked);
        formatter.Serialize(stream, json2);
        stream.Close();
        Debug.Log("Saved End.");
        */
    }


    public void SaveGame()
    {
        WriteToSave();
        Debug.Log("Save complete");
    }

    // Start is called before the first frame update
    void Start()
    {
        SelectedWeapon();
     //   ReadFromSave();
        WriteToSave();

    }

    // Update is called once per frame
    void Update()
    {

    }

    // getter and setters

    // finds the selected weapon, returns a number between 1 to 4 corresponding to the weapon
    public int SelectedWeapon()
    {
        if(petRockSelected == true)
        {
            return 0;
        }
        if (platypusBeamSelected == true)
        {
            return 1;
        }
        if (quackAttackSelected == true)
        {
            return 2;
        }
        if (beesSelected == true)
        {
            return 3;
        }
        else
        {
            Debug.LogError("Weapon has not been selected!");
            return -1;
        }
    }

    public void DeathCount()
    {
        timesDied += 1;
    }
    





}
