using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentryAI : MonoBehaviour
{

    public GameObject sentry;
    public GameObject sentryFirePoint;
    public GameObject player;
    public GameObject missile;
    public bool cooldown;
    public int sentryRange;
    public int projectileNumber;

    public List<GameObject> missileList = new List<GameObject>();
    [SerializeField] private int totalMissiles = 5;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < totalMissiles; i++)
        {
            GameObject temp = Instantiate(missile, new Vector2(99, 99), Quaternion.identity);
            missileList.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, sentry.transform.position) < sentryRange && cooldown == false)
        {
            Fire();
            Debug.Log("Sentry fire");
        }
    }

    void Fire()
    {
        float angle = Mathf.Atan2(player.transform.position.y, player.transform.position.x) * Mathf.Rad2Deg;

        sentryFirePoint.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        missileList[projectileNumber].transform.position = sentryFirePoint.transform.position;
        missileList[projectileNumber].transform.rotation = sentryFirePoint.transform.rotation;

        projectileNumber++;
        if (projectileNumber == 4)
        {
            projectileNumber = 0;
        }
        cooldown = true;
        Debug.Log("Cooldown True");
        StartCoroutine(MissileCooldown());
    }

    public IEnumerator MissileCooldown()
    {
        yield return new WaitForSeconds(2);
        cooldown = false;
        Debug.Log("Cooldown false");
    }
}
