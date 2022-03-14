using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageEnemyAttack : MonoBehaviour
{
    [SerializeField] private GameObject garbageProjectileCircle;
    [SerializeField] private int totalProjectiles;
    public int projectileCooldownSeconds;
    private int projectileNumber;
    [SerializeField] private GameObject shootPoint;

    List<GameObject> projectileCircles = new List<GameObject>();

    public bool fire;
    public bool fireCooldown;

    [SerializeField] private GameObject garbageEnemy;
    [SerializeField] private GameObject player;

    private void Awake()
    {
        projectileNumber = 0;
    }


    // Start is called before the first frame update
    void Start()
    {
        fire = false;

        for (int i = 0; i < totalProjectiles; i++)
        {
            GameObject temp = Instantiate(garbageProjectileCircle, new Vector2(99, 99), Quaternion.identity);
            projectileCircles.Add(temp);
        }

    }

    void Fire()
    {
        if (fireCooldown == false)
        {
            Debug.Log("Fire Garbage!");
            StartCoroutine(ProjectileTimer());

            Vector2 direction = player.transform.position - garbageEnemy.transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

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

        float distance = Vector2.Distance(garbageEnemy.transform.position, player.transform.position);

        if (distance < 20 && fireCooldown == false)
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

