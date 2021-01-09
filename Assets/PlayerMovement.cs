using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Transform x;
	[Range(-2,2)]public float value;
	public float ForwardForce;
	public Rigidbody rb;
	void Start()
	{
		
	}

	void FixedUpdate()
	{
		x.position = new Vector3(value,x.position.y,x.position.z);
		rb.AddForce(0, 0, ForwardForce*Time.deltaTime);
		
	}
	void LateUpdate()
	{
		
		if(Input.GetKeyDown("a"))
		{
			if(value >= 0)
			value-=2;
		}
		if(Input.GetKeyDown("d"))
		{
			if(value <= 0)
			value+=2;
		}
	}
}
