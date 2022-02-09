using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStealthBlink : MonoBehaviour
{
    [SerializeField] private float blinkDuration;
 //   [SerializeField] private float blinkSpeedBoost;
    [SerializeField] private float blinkCooldown;
    [SerializeField] private bool blinkCannotBeActivated;
    [SerializeField] private bool blinkEnd;
    [SerializeField] private GameObject player;
    [SerializeField] public PlayerActionControls playerActionControls;
    [SerializeField] private bool blinkPressed;
    public PlayerMovement playerMovement;


    private void Awake()
    {
        playerActionControls = new PlayerActionControls();
        blinkEnd = false;
        playerActionControls.PlayerControls.EnemyDefensiveWeapon.performed += ctx => blinkPressed = true;
        playerActionControls.PlayerControls.EnemyDefensiveWeapon.canceled += ctx => blinkPressed = false;
    }

    private void OnEnable()
    {
        playerActionControls.Enable();

    }

    private void OnDisable()
    {
        playerActionControls.Disable();

    }

    public void Update()
    {
        if(blinkPressed == true && blinkCannotBeActivated == false)
        {
            StartCoroutine(Blink());

        }
    }

    public IEnumerator Blink()
    {
        Debug.Log("BLINKING");
        blinkCannotBeActivated = true;
        playerMovement.speed = playerMovement.speed * 2;
        yield return new WaitForSeconds(blinkCooldown);
        Debug.Log("Blink ended, cooldown activated");
        blinkEnd = true;
        playerMovement.speed = playerMovement.speed / 2;
        yield return new WaitForSeconds(blinkCooldown);
        Debug.Log("Blink can now be used again");
        blinkCannotBeActivated = false;
    }
}
