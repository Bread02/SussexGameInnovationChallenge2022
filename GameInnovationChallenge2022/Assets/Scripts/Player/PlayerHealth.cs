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
     public PlayerActionControls playerActionControls;
    [SerializeField] private GameObject DeathCanvasMenu;


    //animations
    [SerializeField] private AnimationClip hurtAnimation;
    [SerializeField] private AnimationClip walkingAnimation;

    private Animation hurtAnimationA;
    private Animation walkingAnimationA;

    private bool healthLoss;


    private void Awake()
    {
        hurtAnimationA = GetComponent<Animation>();
        hurtAnimationA.clip = hurtAnimation;

        walkingAnimationA = GetComponent<Animation>();
        walkingAnimationA.clip = walkingAnimation;

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
        hurtAnimationA.Play();

        StartCoroutine(Hurt());
    }

    public void MissileDamage()
    {
        playerHealth -= 30;
        hurtAnimationA.Play();
        StartCoroutine(Hurt());
    }

    public void GarbageProjectileDamage()
    {
        playerHealth -= 20;
        Debug.Log("Enemy taken damage by enemy projectile");
        hurtAnimationA.Play();
        StartCoroutine(Hurt());
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

    public IEnumerator Hurt()
    {

        yield return new WaitForSeconds(1);
        walkingAnimationA.Play();
    }
}
