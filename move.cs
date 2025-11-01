using System;
using UnityEngine;

public class move : MonoBehaviour
{
    public float JumpForce;
    public Rigidbody2D rb;
    
    private bool grounded;
    
    InputSystem_Actions _input;
    void Awake()
    {
        _input = new InputSystem_Actions();
    }

    private void Start()
    {
        _input.Player.Jump.started += _ => Jump();
    }


    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    // Update is called once per frame
   

    public void Jump()
    {
        if (grounded)
        {
            rb.AddForce(Vector2.up * JumpForce);
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy");
            Time.timeScale = 0; 
        }
        Debug.Log("Enter");
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
        Debug.Log("Exit");
    }
}
