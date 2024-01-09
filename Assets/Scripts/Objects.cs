using UnityEngine;

public class Objects : MonoBehaviour
{
	protected Rigidbody rb;
	private float initialY;
	[SerializeField] private float lowestY = 0.1f;
	[SerializeField] private float jumpForce = 5.0f;
	[SerializeField] protected float turnY = 0.5f;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		initialY = transform.position.y;
	}

	virtual protected void Jump()
	{
		rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
	}

	virtual protected void Rotation()
	{
		transform.Rotate(0, turnY, 0);
	}

	// Update is called once per frame
	void Update()
	{
		Rotation();
		if (transform.position.y - initialY < lowestY && Input.GetKeyDown(KeyCode.Space))
			Jump();
	}
}
