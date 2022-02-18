using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a coned area of attack weapon.
// The intended area of attack angle is 90' of where the mouse faces
// The cone will only activate when the player 'fires' the weapon.
public class PlayerGooseAttack : MonoBehaviour
{
    [SerializeField] private int attackAngle;
    [SerializeField] private int damage;
    [SerializeField] private PlayerActionControls playerActionControls;
    [SerializeField] private int WeaponCooldownTime;
    private bool fire;
    private bool fireCooldown;
    public GameObject shootPoint;
    public GameObject semiCircle;

    [SerializeField] private AudioSource honkAudioSource;

    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    } 

    private void Awake()
    {
        semiCircle.SetActive(false);
        playerActionControls = new PlayerActionControls();
        playerActionControls.PlayerControls.PlayerFireWeapon.performed += ctx => fire = true;
        playerActionControls.PlayerControls.PlayerFireWeapon.canceled += ctx => fire = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = playerActionControls.PlayerControls.PlayerFacing.ReadValue<Vector2>();
        mousePosition.x -= Screen.width / 2;
        mousePosition.y -= Screen.height / 2;
        float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;

        semiCircle.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if(fire == true)
        {
            Fire();
        }


    }

    void Fire()
    {
        if (fireCooldown == false)
        {
            Debug.Log("Honk!");
            honkAudioSource.Play();
            semiCircle.SetActive(true);
            fireCooldown = true;
            StartCoroutine(FireCooldown());
        }
    }

    IEnumerator FireCooldown()
    {
        yield return new WaitForSeconds(WeaponCooldownTime);
        semiCircle.SetActive(false);
        fireCooldown = false;
    }
}
