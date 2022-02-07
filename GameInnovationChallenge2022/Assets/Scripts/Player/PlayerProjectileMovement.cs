using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerProjectileMovement : MonoBehaviour
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
        
        foreach (GameObject foo in GameObject.FindGameObjectsWithTag("EnemyOne"))
        {
             damageableGameObjects.Add(foo);
        }

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
    /*
    public void ProjectileDamage()
    {
        foreach (var damageableGameObject in damageableGameObjects)
        {
            
            var damageable = damageableGameObject.GetComponent<IEnemyDamage>();
            Debug.Log("Projectile Damage");
            damageable.ProjectileDamage();
        }
    }

    */
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (var damageableGameObject in damageableGameObjects)
        {
            var damageable = damageableGameObject.GetComponent<IEnemyDamage>();
            Debug.Log("Projectile Damage");
            damageable.ProjectileDamage();
        }

    }

}
