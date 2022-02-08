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
    }

    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player")
        {
            projectile.transform.position = new Vector2(1000, 0);
            Debug.Log("TELEPORTING PROJECTILE");
        }
    }

}
