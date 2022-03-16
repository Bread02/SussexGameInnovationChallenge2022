using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemyProjectileMovement : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed;
    public GameObject cursor;
    [SerializeField] private GameObject player;
    public GameObject sentry;
    [SerializeField] private List<GameObject> damageableGameObjects;

    void Start()
    {
        projectile = this.gameObject;
        player = GameObject.Find("Player");
        sentry = GameObject.Find("Sentry");

        damageableGameObjects.Add(player);

    }

    // Update is called once per frame
    void Update()
    {
        projectile.transform.position += transform.right * projectileSpeed * Time.deltaTime;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            // Make player take damage
        //    IPlayerDamage.GarbageProjectileDamage();
        }
    }

}
