using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowAI : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private Vector2 movement;
    [SerializeField] private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.transform.position - enemy.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

        MoveEnemy(direction);
    }

    void MoveEnemy(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
