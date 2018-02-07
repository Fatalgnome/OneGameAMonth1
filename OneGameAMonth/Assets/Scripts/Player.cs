using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private float curSpeed;
    private Vector2 movDir;
    private Rigidbody2D rigidbody;
    
    public LayerMask groundLayer;
    public float Speed = 3.0f;
    public float jumpSpeed;


    // Use this for initialization
    void Start ()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
	{
        
	    if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
	    {
	        movDir += Vector2.left;
	        transform.Translate(movDir * Speed * Time.deltaTime, Camera.main.transform);
        }
	    else
	    {
	        movDir = transform.forward;
	    }

	    if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
	    {
	        movDir += Vector2.right;
	        transform.Translate(movDir * Speed * Time.deltaTime, Camera.main.transform);
        }
	    else
	    {
	        movDir = transform.forward;
	    }

        

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
	    {
	        rigidbody.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse );
	    }

	}

    public bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1, groundLayer);
        
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }

}
