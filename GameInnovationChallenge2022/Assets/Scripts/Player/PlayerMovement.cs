using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script flips the player when the mouse cursor position is to the left of the player, and vice versa.
// This script also controls the player movement using the new input scheme.
public class PlayerMovement : MonoBehaviour
{
    private GameObject player;
    [SerializeField] public float speed;
    [SerializeField] private PlayerActionControls playerActionControls;
    private Rigidbody2D rb;
    private float mouseAngle;

    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        playerActionControls = new PlayerActionControls();
        playerActionControls.Enable();
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FlipPlayer()
    {
        player.GetComponent<SpriteRenderer>().flipX = true;
    }

    void UnFlipPlayer()
    {
        player.GetComponent<SpriteRenderer>().flipX = false;
    }
    

    // tracks the position of the mouse on the screen through the new input system.
    void MouseTrack()
    {
        Vector2 mousePosition = playerActionControls.PlayerControls.PlayerFacing.ReadValue<Vector2>();
        mousePosition.x -= Screen.width / 2;
        mousePosition.y -= Screen.height / 2;

        if (mousePosition.x < 0)
        {
            FlipPlayer();
        }

        if (mousePosition.x > 0)
        {
            UnFlipPlayer();
        }

        float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
        mouseAngle = angle;

    }
    void Update()
    {
        float movementInput = playerActionControls.PlayerControls.HorizontalMovement.ReadValue<float>();
        rb.AddForce(new Vector2(movementInput * speed * Time.deltaTime, 0));

        float verticalMovementInput = playerActionControls.PlayerControls.VerticalMovement.ReadValue<float>();
        rb.AddForce(new Vector2(0, verticalMovementInput * speed * Time.deltaTime));

        MouseTrack();
    }
}
