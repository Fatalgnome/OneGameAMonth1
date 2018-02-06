using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
    public float Speed = 3.0f;
    private float curSpeed;
    private float jumpSpeed;

    private CharacterController cc;
    private Vector2 up;
    private Vector2 forward;
    public LayerMask groundLayer;

    // Use this for initialization
    void Start ()
	{
	    cc = GetComponent<CharacterController>();
        up = transform.TransformDirection(new Vector2(0, 1));
        forward = transform.TransformDirection(new Vector2(1, 0));
    }
	
	// Update is called once per frame
	void Update ()
	{
	    curSpeed = Speed * Input.GetAxis("Horizontal");
        cc.SimpleMove(forward * curSpeed);


	    if (Input.GetKeyDown(KeyCode.Space) && cc.isGrounded)
	    {
	        
	    }
	}

}
