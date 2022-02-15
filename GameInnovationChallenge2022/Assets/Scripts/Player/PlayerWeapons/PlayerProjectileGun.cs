using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectileGun : MonoBehaviour
{

    [SerializeField] private GameObject projectileCircle;
    [SerializeField] public PlayerActionControls playerActionControls;
    [SerializeField] private int totalProjectiles;
    public int projectileCooldownSeconds;
    private int projectileNumber;
    [SerializeField] private GameObject shootPoint;

    List<GameObject> projectileCircles = new List<GameObject>();

    public bool fire;
    public bool fireCooldown;

    private void Awake()
    {
        playerActionControls = new PlayerActionControls();

        playerActionControls.PlayerControls.PlayerFireWeapon.performed += ctx => fire = true;
        playerActionControls.PlayerControls.PlayerFireWeapon.canceled += ctx => fire = false;
        projectileNumber = 0;


    }

    private void OnEnable()
    {
        playerActionControls.Enable();

    }

    private void OnDisable()
    {
        playerActionControls.Disable();

    }

    // Start is called before the first frame update
    void Start()
    {
        fire = false;

        for (int i = 0; i < totalProjectiles; i++)
        {
            GameObject temp = Instantiate(projectileCircle, new Vector2(99, 99), Quaternion.identity);
            projectileCircles.Add(temp);
        }
        
    }

    void Fire()
    {
        if (fireCooldown == false)
        {
            Debug.Log("Fire!");
            StartCoroutine(ProjectileTimer());

            Vector2 mousePosition = playerActionControls.PlayerControls.PlayerFacing.ReadValue<Vector2>();
            mousePosition.x -= Screen.width / 2;
            mousePosition.y -= Screen.height / 2;
            float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;

            shootPoint.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

            projectileCircles[projectileNumber].transform.position = shootPoint.transform.position;
            projectileCircles[projectileNumber].transform.rotation = shootPoint.transform.rotation;

            projectileNumber++;
            if (projectileNumber == 4)
            {
                projectileNumber = 0;
            }
        }
    }

    // Update is called once per frame
    public void Update()
    {
        // Debug.Log(fire);

        if (fire == true && fireCooldown == false)
        {
            Fire();
        }

    }

    public IEnumerator ProjectileTimer()
    {
        fireCooldown = true;
        yield return new WaitForSeconds(projectileCooldownSeconds);
        fireCooldown = false;
    }

}
