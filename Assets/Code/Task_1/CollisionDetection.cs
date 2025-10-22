using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("FallingCube"))
		{
			GameManager.Instance.AddScore(1);
			Destroy(collision.gameObject); // evita contar duas vezes o mesmo
		}
	}
}
