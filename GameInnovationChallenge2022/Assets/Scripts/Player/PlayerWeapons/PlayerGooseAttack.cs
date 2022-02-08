using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a coned area of attack weapon.
// The intended area of attack angle is 90' of where the mouse faces
public class PlayerGooseAttack : MonoBehaviour
{
    [SerializeField] private int attackAngle;
    [SerializeField] private int damage;
    [SerializeField] public PlayerActionControls playerActionControls;
    public bool fire;
    public bool fireCooldown;
    public GameObject shootPoint;
    public GameObject semiCircle;

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
        playerActionControls = new PlayerActionControls();

        playerActionControls.PlayerControls.PlayerFireWeapon.performed += ctx => fire = true;
        playerActionControls.PlayerControls.PlayerFireWeapon.canceled += ctx => fire = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fire()
    {
        if (fireCooldown == false)
        {
            Debug.Log("Honk!");

            Vector2 mousePosition = playerActionControls.PlayerControls.PlayerFacing.ReadValue<Vector2>();
            mousePosition.x -= Screen.width / 2;
            mousePosition.y -= Screen.height / 2;
            float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;

            shootPoint.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }
}
