using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissile : MonoBehaviour, IPlayerDamage
{
    public GameObject player;
    public GameObject missile;
    public Rigidbody2D rb;
    public float damageDistance;
    public float speed;
    public float missileFuelSeconds = 3;


    public void Start()
    {
        speed = 10;
        damageDistance = 2;
    }

    public void MissileDamage()
    {
        Debug.Log("Missile exploded");
        missile.SetActive(false);
    }

    public void Update()
    {
        player = GameObject.Find("Player");
        missile = this.gameObject;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        missile.transform.LookAt(player.transform);

        missile.transform.position += transform.right * speed * Time.deltaTime;

        if (Vector2.Distance(player.transform.position, missile.transform.position) < damageDistance )
        {
            MissileDamage();
        }

    }
}
