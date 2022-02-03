using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerProjectileMovement : MonoBehaviour, IEnemyDamage
{

  //  public Rigidbody2D rb;
    public GameObject projectile;
    public float projectileSpeed;
    public GameObject cursor;
    public GameObject player;
    public GameObject sentry;
    [SerializeField] private List<GameObject> damageableGameObjects;

    void Start()
    {
        projectile = this.gameObject;
        player = GameObject.Find("Player");
        sentry = GameObject.Find("Sentry");

   //     damageableGameObjects.Add("Sentry");
        /*
        var ss = FindObjectsOfType<MonoBehaviour>().OfType<IEnemyDamage>();
        foreach (IEnemyDamage s in ss)
        {
            damageableGameObjects.Add(s);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        projectile.transform.position += transform.right * projectileSpeed * Time.deltaTime;


        /*
        if (Vector2.Distance(projectile.transform.position, damageableGameObject.transform.position) < 1)
        {
            ProjectileDamage();
        }
        */

    }

    public void ProjectileDamage()
    {
        foreach (var damageableGameObject in damageableGameObjects)
        {
            var damageable = damageableGameObject.GetComponent<IEnemyDamage>();
            Debug.Log("Projectile Damage");
            damageable.ProjectileDamage();
        }
    }

}