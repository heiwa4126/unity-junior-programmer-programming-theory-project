using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
	private Rigidbody rb;
	private float initialY;
	[SerializeField] private float lowestY = 0.1f;
	[SerializeField] private float jumpForce = 5.0f;
	[SerializeField] private float turnY = 0.5f;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		initialY = transform.position.y;
	}

	public void Jump()
	{
		rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(0, turnY, 0);

		if (transform.position.y - initialY < lowestY && Input.GetKeyDown(KeyCode.Space))
			Jump();
	}
}
