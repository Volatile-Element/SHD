﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	private Vector2 target;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if (target != null)
		{
			transform.position = Vector2.MoveTowards(transform.position, target, 5 * Time.deltaTime);
		}
		//transform.Translate (new Vector3(Vector3.forward.x, Vector3.forward.y, 0) * 0.15f);
	}

	public void SetTarget(Vector2 targ)
	{
		target = targ;
	}

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Defence Point")
		{
			c.gameObject.SendMessage("Damage" , 1);

			Destroy (gameObject);
		}

		if (c.gameObject.tag == "Bullet Stop")
			Destroy (gameObject);
	}
}