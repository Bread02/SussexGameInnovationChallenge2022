using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentryHealth : MonoBehaviour, IEnemyDamage
{
    public float sentryHealth;
    public GameObject sentry;

    // Start is called before the first frame update
    void Start()
    {
        sentryHealth = 100;
        sentry = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (sentryHealth <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        sentry.SetActive(false);
    }

    public void ProjectileDamage()
    {
        sentryHealth -= 10;
        Debug.Log("Projectile health loss");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerProjectile")
        {
            ProjectileDamage();
        }
    }
}
