using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStealthBlink : MonoBehaviour
{
    [SerializeField] private float blinkDuration;
    [SerializeField] private float blinkCooldown;
    [SerializeField] private bool blinkCannotBeActivated;
    [SerializeField] private bool blinkEnd;
    private GameObject player;
    [SerializeField] public PlayerActionControls playerActionControls;
    [SerializeField] private bool blinkPressed;
    public PlayerMovement playerMovement;

    public float originalBlinkCooldown;

    public Image stealthBlinkCoolDownImage;
    public Image stealthBlinkCoolDownImageRED;


    private void Awake()
    {
        player = this.gameObject;
        playerActionControls = new PlayerActionControls();
        blinkEnd = false;
        playerActionControls.PlayerControls.EnemyDefensiveWeapon.performed += ctx => blinkPressed = true;
        playerActionControls.PlayerControls.EnemyDefensiveWeapon.canceled += ctx => blinkPressed = false;

        stealthBlinkCoolDownImage.fillAmount = 1;
        originalBlinkCooldown = blinkCooldown;
        stealthBlinkCoolDownImage.enabled = true;
        stealthBlinkCoolDownImageRED.enabled = false;
    }

    private void OnEnable()
    {
        playerActionControls.Enable();

    }

    private void OnDisable()
    {
        playerActionControls.Disable();

    }

    public void FixedUpdate()
    {
        if(blinkPressed == true && blinkCannotBeActivated == false)
        {
            StartCoroutine(Blink());

        }
        if (blinkEnd == true)
        {
            blinkCooldown += Time.deltaTime;
            stealthBlinkCoolDownImage.fillAmount += blinkCooldown * 0.1f;
        }
        if (blinkCooldown > 3)
        {
            stealthBlinkCoolDownImage.fillAmount = 1;
        }
    }

    public void BlinkCoolDownImageFill()
    {
        Debug.Log("Cooldown Void");
        stealthBlinkCoolDownImage.fillAmount = 0;
    }

    public IEnumerator Blink()
    {
        Debug.Log("BLINKING");
        stealthBlinkCoolDownImage.enabled = false;
        stealthBlinkCoolDownImageRED.enabled = true;
        blinkCannotBeActivated = true;
        playerMovement.speed = playerMovement.speed * 2;
        yield return new WaitForSeconds(originalBlinkCooldown);
        stealthBlinkCoolDownImageRED.enabled = false;
        stealthBlinkCoolDownImage.enabled = true;
        blinkCooldown = 0;
        Debug.Log("Blink ended, cooldown activated");
        BlinkCoolDownImageFill();
        blinkEnd = true;
        playerMovement.speed = playerMovement.speed / 2;
        yield return new WaitForSeconds(originalBlinkCooldown);
        blinkCooldown = originalBlinkCooldown;
        blinkEnd = false;
        Debug.Log("Blink can now be used again");
        blinkCannotBeActivated = false;
    }
}
