using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltPlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody2D playerRb;
    [SerializeField] private float speed;
    [SerializeField] public PlayerActionControls playerActionControls;
    [SerializeField] private Rigidbody2D rb;
    public bool jump;
    public bool fire;
    private float mouseAngle;

    public bool isGrounded;
    public bool canJump;
    public float jumpPower;

    private void Awake()
    {
        playerActionControls = new PlayerActionControls();
        playerActionControls.PlayerControls.Jump.started += ctx => jump = true;
    //    playerActionControls.PlayerControls.Jump.performed += ctx => jump = true;
        playerActionControls.PlayerControls.Jump.canceled += ctx => jump = false;

    }

    void Start()
    {
        player = this.gameObject;
        playerRb = this.gameObject.GetComponent<Rigidbody2D>();
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;

    }

    private void OnEnable()
    {
        playerActionControls.Enable();

    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    }


        // Update is called once per frame
        void Update()
    {
        float movementInput = playerActionControls.PlayerControls.HorizontalMovement.ReadValue<float>();
        rb.AddForce(new Vector2(movementInput * speed * Time.deltaTime, 0));

        float verticalMovementInput = playerActionControls.PlayerControls.VerticalMovement.ReadValue<float>();
        rb.AddForce(new Vector2(0, verticalMovementInput * speed * Time.deltaTime));

        if (jump == true)
        {
            Jump();
        }



        //   playerActionControls.PlayerControls.Flip.performed += _ => FlipPlayer();

        MouseTrack();
        //    Debug.Log(player.transform.eulerAngles.z);

        /*
        if (player.transform.eulerAngles.z > 90)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        */
    }

    void FlipPlayer()
    {
        //    Debug.Log("Flipping player");
        player.GetComponent<SpriteRenderer>().flipX = true;
        //  flipped = true;

    }

    void UnFlipPlayer()
    {
        //  Debug.Log("UnFlipping player");
        player.GetComponent<SpriteRenderer>().flipX = false;
        //  flipped = false;
    }

    void MouseTrack()
    {
        Vector2 mousePosition = playerActionControls.PlayerControls.PlayerFacing.ReadValue<Vector2>();
        mousePosition.x -= Screen.width / 2;
        mousePosition.y -= Screen.height / 2;
        // Debug.Log(mousePosition);

        if (mousePosition.x < 0)
        {
            FlipPlayer();
        }

        if (mousePosition.x > 0)
        {
            UnFlipPlayer();
        }

        //   player.transform.LookAt(new Vector3(0, 0, mousePosition.y));

        float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;

        //     player.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        mouseAngle = angle;

    }

    public void Jump()
    {
        Debug.Log("Jump!");
        if (isGrounded == true)
        {
            isGrounded = false;

            if (playerRb.gravityScale == 4)
            {
                playerRb.gravityScale = -4;
                Debug.Log("GRAVITY SET TO MINUS");
                return;
            }
            if(playerRb.gravityScale == -4)
            {
                playerRb.gravityScale = 4;
                Debug.Log("GRAVITY SET TO POSITIVE");
                return;
            }

        }
    }
}
