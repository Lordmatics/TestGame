using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class PacDots : MonoBehaviour 
{

	private Rigidbody2D 		m_rb;
	private CircleCollider2D 	m_col;

	void Awake()
	{
		m_rb = GetComponent<Rigidbody2D> ();
		m_col = GetComponent<CircleCollider2D> ();
	}

	void Start () 
	{
		m_col.isTrigger = true;
		m_rb.isKinematic = true;
		m_rb.freezeRotation = true;
	}

	void Update () 
	{
	}

	void OnTriggerEnter2D(Collider2D other)
	{

	}

	public void OnEaten()
	{
		Destroy (gameObject);
	}
}
