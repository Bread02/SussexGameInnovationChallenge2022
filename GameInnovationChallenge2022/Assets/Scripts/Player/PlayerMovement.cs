using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;
    [SerializeField] private PlayerActionControls playerActionControls;
    [SerializeField] private Rigidbody2D rb;
   // [SerializeField] private bool flipped;
    private float mouseAngle;
    // [SerializeField] private Camera camera;

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

    // Update is called once per frame
    void Update()
    {
        float movementInput = playerActionControls.PlayerControls.HorizontalMovement.ReadValue<float>();
        rb.AddForce(new Vector2(movementInput * speed * Time.deltaTime, 0));

        float verticalMovementInput = playerActionControls.PlayerControls.VerticalMovement.ReadValue<float>();
        rb.AddForce(new Vector2(0, verticalMovementInput * speed * Time.deltaTime));


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
}
