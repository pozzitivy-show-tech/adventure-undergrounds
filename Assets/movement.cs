using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public Rigidbody2D body;

	public float horizontal;
	public float vertical;

	public float runSpeed = 20.0f;

	public Joystick joystick;

	public SpriteRenderer spriteRenderer;

	void Start ()
	{
		body = GetComponent<Rigidbody2D>(); 
	}

	void Update ()
	{	

		if (joystick.Horizontal >= 0.2f)
		{
			if( joystick.Vertical >= 0.2f)
			{
				horizontal = 1;
				vertical = 1;
			}
			else if (joystick.Vertical <= -0.2f)
			{
				horizontal = 1;
				vertical = -1;
			}
			else 
			{
				horizontal = 1;
				vertical = 0;
			}
			
		} 
		else if (joystick.Horizontal <= -0.2f)
		{
			if( joystick.Vertical >= 0.2f)
			{
				horizontal = -1;
				vertical = 1;
			}
			else if (joystick.Vertical <= -0.2f)
			{
				horizontal = -1;
				vertical = -1;
			}
			else 
			{
				horizontal = -1;
				vertical = 0;
			}
			
		}
		else
		{
			if( joystick.Vertical >= 0.2f)
			{
				horizontal = 0;
				vertical = 1;
			}
			else if (joystick.Vertical <= -0.2f)
			{
				horizontal = 0;
				vertical = -1;
			}
			else 
			{
				horizontal = 0;
				vertical = 0;
			}
			
		}
		if(joystick.gameObject.transform.parent.gameObject.activeSelf == false)
        {

			horizontal = 0;
			vertical = 0;
        }
	}


	private void FixedUpdate()
	{
		if (horizontal == 1 || horizontal == -1)
		{
			Vector3 charScale = transform.localScale;
			charScale.x = Mathf.Abs(charScale.x) * horizontal;
			transform.localScale = charScale;
		}  
		body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);

	}

}
