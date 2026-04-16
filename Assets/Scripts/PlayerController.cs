using UnityEngine;
using UnityEngine.InputSystem;

//https://www.youtube.com/watch?v=a4oQcohR_gE
public class PlayerController : MonoBehaviour
{

    public InputSystemTest actions;
    public Rigidbody2D rb;
    public float speed;
    public float jumpforce;
    public Transform groundCheckTransform;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    bool isGrounded;
    private float move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awake()
    {
        actions = new InputSystemTest();
    }
    
    private void OnEnable()
    {
        actions.Player.Enable();
        actions.Player.Move.performed+=Movement;
        actions.Player.Jump.performed+=Jumping;


        actions.Player.Move.canceled+=Movement;
        actions.Player.Jump.canceled+=Jumping;
    
    }

    void Movement(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>().x;
    }

    void Jumping(InputAction.CallbackContext context)
    {

        if (context.performed)
        {
            if (isGrounded)
            {
                rb.linearVelocityY = jumpforce;
            }
            
        }
        
    }

    private void OnDisable()
    {
        actions.Player.Disable();
        actions.Player.Move.performed-=Movement;
        actions.Player.Jump.performed-=Jumping;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocityX = move * speed;
        isGrounded = Physics2D.OverlapCircle(groundCheckTransform.position, groundCheckRadius, groundLayer);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckTransform.position,groundCheckRadius);
    }
    

}
    
