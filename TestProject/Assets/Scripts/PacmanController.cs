using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class PacmanController : MonoBehaviour 
{

	private Rigidbody2D 		m_rb;
	private CircleCollider2D 	m_col;

	[SerializeField]
	private float m_moveSpeed;

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
		m_moveSpeed = 5.0f;
	}
	
	void Update () 
	{
		float h = Input.GetAxis ("Horizontal");

		Vector3 moveVec = h * m_moveSpeed * Time.deltaTime * Vector3.right;
		transform.Translate (moveVec);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		PacDots script = other.gameObject.GetComponent<PacDots> ();
		if (script != null) 
		{
			script.OnEaten ();
		}
	}
}
