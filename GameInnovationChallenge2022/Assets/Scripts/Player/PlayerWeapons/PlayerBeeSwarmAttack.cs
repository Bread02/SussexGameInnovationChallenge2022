using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// work in progress weapon
public class PlayerBeeSwarmAttack : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private GameObject beeSwarm;
    [SerializeField] private bool fire;
    [SerializeField] private PlayerActionControls playerActionControls;
    [SerializeField] private List<Transform> damageableGameObjects;
    [SerializeField] private Vector2 currentPosition;
    [SerializeField] private float minDist;
    [SerializeField] private Transform tMin;

    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        playerActionControls = new PlayerActionControls();

        playerActionControls.PlayerControls.PlayerFireWeapon.performed += ctx => fire = true;
        playerActionControls.PlayerControls.PlayerFireWeapon.canceled += ctx => fire = false;
        beeSwarm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        FindEnemy();

        if(fire == true)
        {
            AttackEnemy();
            MoveTowardEnemy();
        }
    }

    void FindEnemy()
    {
        foreach (GameObject foo in GameObject.FindGameObjectsWithTag("EnemyOne"))
        {
            damageableGameObjects.Add(foo.transform);
        }
    }

    Transform AttackEnemy()
    {
        foreach (Transform t in damageableGameObjects)
        {
            float dist = Vector2.Distance(t.position, currentPosition);
            if (dist < minDist)
            {
                tMin = t;
                minDist = dist;
            }
        }
        return tMin;
    }

    void MoveTowardEnemy()
    {
        beeSwarm.transform.position = Vector2.MoveTowards(transform.position, tMin.transform.position, 2);
    }
}
