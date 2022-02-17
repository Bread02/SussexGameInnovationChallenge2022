using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour, IPlayerDamage
{
    [SerializeField] int playerHealth = 100;
    public Image playerHealthFG;
    [SerializeField] public PlayerActionControls playerActionControls;
    public bool healthLoss;

    private void Awake()
    {
        playerActionControls = new PlayerActionControls();

        playerActionControls.DebugControls.HealthLoss.performed += ctx => healthLoss = true;
        playerActionControls.DebugControls.HealthLoss.canceled += ctx => healthLoss = false;

    }

    private void OnEnable()
    {
        playerActionControls.Enable();

    }

    private void OnDisable()
    {
        playerActionControls.Disable();

    }

    public void Start()
    {
     //   playerHealthFG = GameObject.Find("PlayerHealthFG");

    }

    // Update is called once per frame
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

    void HealthLoss()
    {
        playerHealth -= 5;
    }

    public void MissileDamage()
    {
        playerHealth -= 30;
    }

    public void PlayerDeath()
    {
        Debug.Log("Player has died");
    }
}
