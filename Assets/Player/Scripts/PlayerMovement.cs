using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [Header("General")]

    [SerializeField] private Rigidbody rb;
    //[SerializeField] private SoundPlayer sP;

    [Header("Movement")]
    [SerializeField, Range(0, 3)] private float drag;
    [SerializeField] private float moveForceNormal;
    [SerializeField, Range(0, 20)] private float maxVelocity;
    
    private Vector3 lookPosition = Vector3.zero;
    private bool moving = false;
    private float currentMoveForce;


    [Header("Jump")]
    [SerializeField] private float jumpVelocity;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField, Range(0, 1)] private float groundCheckLenght;
    bool grounded = false;



    void Start()
    {
        rb.drag = drag;
        currentMoveForce = moveForceNormal;
    }



    void Update()
    {
        checkGround();
    }

    void OnEnable(){
    }
    private void checkGround()
    {
        bool prev = grounded;
        grounded = Physics.Raycast(groundCheck.position, - Vector3.up, groundCheckLenght + 0.1f, groundLayer);
        //if (grounded && !prev)
            //sP.PlaySound("Fall");
    }

    void FixedUpdate()
    {
        move();
    }

    private void move()
    {
        
        if (moving)
        {
            //sP.PlaySound(currentStepSound);
            rb.AddForce(transform.forward * currentMoveForce);
        }
          
        clampVelocity();
    }

    private void clampVelocity()
    {
        Vector3 vel = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        if (vel.magnitude > maxVelocity)
        {
            vel = Vector3.ClampMagnitude(vel, maxVelocity);
            rb.velocity = new Vector3(vel.x, rb.velocity.y, vel.z);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();
        if (value == Vector2.zero)
        {
            //sP.StopSound("SweetStep");
            //sP.StopSound("Step");
        }
        lookPosition.x = transform.position.x + value.x;
        lookPosition.y = transform.position.y;
        lookPosition.z = transform.position.z + value.y;
        transform.LookAt(lookPosition, Vector3.up);
        moving = value.x != 0 || value.y != 0;
        //anim.SetBool("walking", moving);
        //anim.SetBool("idle", !moving);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed)
            if (grounded)
                rb.velocity = new Vector3(rb.velocity.x, jumpVelocity, rb.velocity.z);
    }



    void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(groundCheck.position, - groundCheck.up * groundCheckLenght);
    }

    

    
}

