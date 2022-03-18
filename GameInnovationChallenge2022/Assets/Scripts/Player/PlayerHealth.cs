using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour, IPlayerDamage
{
    [SerializeField] private int playerHealth = 100;

    // player health foreground which is found in the HUD Canvas
    [SerializeField] private Image playerHealthFG;
    [SerializeField] private GameObject DeathCanvas;
    [SerializeField] public PlayerActionControls playerActionControls;
    [SerializeField] private GameObject DeathCanvasMenu;

    //player sprites
    [SerializeField] private Sprite playerDamageSprite;
    [SerializeField] private Sprite playerNormalSprite;

    private bool healthLoss;


    private void Awake()
    {
        // this connects the new input system to the health loss button, O.
        playerActionControls = new PlayerActionControls();
        playerActionControls.DebugControls.HealthLoss.performed += ctx => healthLoss = true;
        playerActionControls.DebugControls.HealthLoss.canceled += ctx => healthLoss = false;
        DeathCanvas.SetActive(false);
        DeathCanvasMenu.SetActive(false);

    }
    // the On enable and On disable connect the script to the new input scheme.
    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    }

    //  playerHealthFG.fillAmount = playerHealth / 100 sets the healthbar to go down assuming the player's health is 100

    void Update()
    {
        playerHealthFG.fillAmount = playerHealth / 100;

        if (healthLoss == true)
        {
            Debug.Log("Health Lost");
            HealthLoss();
        }

        if (playerHealth == 0)
        {
            PlayerDeath();
        }
    }

    // triggers health losses through the interface
    void HealthLoss()
    {
        playerHealth -= 5;
    }

    public void MissileDamage()
    {
        playerHealth -= 30;
    }

    public void GarbageProjectileDamage()
    {
        playerHealth -= 20;
        Debug.Log("Enemy taken damage by enemy projectile");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("player Collided with something");
        if (collision.tag == "GarbageEnemyProjectile")
        {
            GarbageProjectileDamage();
        }
    }

        // player death
        public void PlayerDeath()
    {
        Debug.Log("Player has died");
        DeathCanvas.SetActive(true);
        DeathCanvasMenu.SetActive(true);
    }
}
