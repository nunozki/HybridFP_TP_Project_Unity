using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float playerSpeed = 10.0f;
	private Rigidbody rb;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.AddForce(movement * playerSpeed);
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("FallingCube"))
		{
			GameManager.Instance.GameOver();
			Destroy(gameObject); // Remove player cube
		}
	}
}
