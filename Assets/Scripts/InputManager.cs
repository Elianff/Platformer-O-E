using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    //vector2 smoothInput;
    public float smoothSpeed = 3.0f;
    private bool isAttacking;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["Move"];
        mouseAction = playerInput.actions["Look"];*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void OnAttack (InputAction.CallbackContext context)
    {
        #region Input.GetButtonDown;

        if (context.performed)
        {
            Debug.Log("Attack");
            isAttacking = true;
        }

        #region Input.GetButtonUp;
        if (context.canceled)
        {
            Debug.Log("Stop Attack");
            isAttacking = false;
        }

        #endregion
    }
    #endregion

    */
}