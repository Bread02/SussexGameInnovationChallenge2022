using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SentryHealth : MonoBehaviour, IEnemyDamage
{
    public float sentryHealth;
    public GameObject sentry;
    public Image healthFG;

    public GameDataManager gameDataManager;

    // Start is called before the first frame update
    void Start()
    {
        sentryHealth = 20;
        sentry = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (sentryHealth <= 0)
        {
            Death();
        }
        healthFG.fillAmount = sentryHealth / 100;
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

    public void ConeDamage()
    {
        sentryHealth -= 5;
        Debug.Log("Cone health loss");
    }

    public void BeamDamage()
    {
        sentryHealth -= 5;
        Debug.Log("beam health loss");
    }

    public void FireDamage()
    {
        StartCoroutine(FireDOT());
    }

    IEnumerator FireDOT()
    {
        Debug.Log("SENTRY FIRE DAMAGE");
        sentryHealth -= 5;
        yield return new WaitForSeconds(0.5f);
        sentryHealth -= 5;
        yield return new WaitForSeconds(0.5f);
        sentryHealth -= 5;
        yield return new WaitForSeconds(0.5f);
        sentryHealth -= 5;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerProjectile")
        {
            ProjectileDamage();
        }

        if(collision.tag == "PlayerConeAttack")
        {
            ConeDamage();
            Debug.Log("COllided with Cone");
        }

        if (collision.tag == "PlayerBeamAttack")
        {
            BeamDamage();
            Debug.Log("COllided with beam");
            /*
            if(gameDataManager.platypusBeamFire == true)
            {
                FireDamage();
            }
            */
        }
    }
}
