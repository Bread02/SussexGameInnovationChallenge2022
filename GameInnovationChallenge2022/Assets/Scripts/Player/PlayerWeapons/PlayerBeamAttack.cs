using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this attack fires a beam towards the cursor position
public class PlayerBeamAttack : MonoBehaviour
{
    [SerializeField] private GameObject beam;
    [SerializeField] private GameObject beamPivot;
    private GameObject player;
    [SerializeField] private PlayerActionControls playerActionControls;

    [SerializeField] private bool fire;
    [SerializeField] private bool fireCooldown;

    private void Awake()
    {
        player = this.gameObject;
        playerActionControls = new PlayerActionControls();

        playerActionControls.PlayerControls.PlayerFireWeapon.performed += ctx => fire = true;
        playerActionControls.PlayerControls.PlayerFireWeapon.canceled += ctx => fire = false;
        beam.SetActive(false);

    }

    private void OnEnable()
    {
        playerActionControls.Enable();

    }

    private void OnDisable()
    {
        playerActionControls.Disable();

    }

    void Update()
    {
        Vector2 mousePosition = playerActionControls.PlayerControls.PlayerFacing.ReadValue<Vector2>();
        mousePosition.x -= Screen.width / 2;
        mousePosition.y -= Screen.height / 2;
        float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;

        beamPivot.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (fire == true)
        {
            Fire();
        }


    }
    void Fire()
    {
        if (fireCooldown == false)
        {
            Debug.Log("Honk!");
         //  honkAudioSource.Play();
            beam.SetActive(true);
            fireCooldown = true;
            StartCoroutine(FireCooldown());
        }
    }

    IEnumerator FireCooldown()
    {
        yield return new WaitForSeconds(1);
        beam.SetActive(false);
        fireCooldown = false;
    }
}
