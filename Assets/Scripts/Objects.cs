using UnityEngine;
using UnityEngine.InputSystem;

public class Objects : MonoBehaviour
{
	private float initialY;
	protected Rigidbody rb;
	const float lowestY = 0.1f;
	[SerializeField] private float jumpForce = 5.0f;
	protected float TurnY { get; private set; } = 90.0f; // ENCAPSULATION

	void Start() // INHERITANCE
	{
		rb = GetComponent<Rigidbody>();
		initialY = transform.position.y;
	}

	void Update() // INHERITANCE
	{
		Rotation();
		if (transform.position.y - initialY < lowestY
			&& Keyboard.current.spaceKey.wasPressedThisFrame)
		{
			Jump();
		}
	}

	private void Jump() // ABSTRACTION
	{
		rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
	}

	virtual protected void Rotation() // POLYMORPHISM and ABSTRACTION
	{
		transform.Rotate(0, TurnY * Time.deltaTime, 0);
	}
}
