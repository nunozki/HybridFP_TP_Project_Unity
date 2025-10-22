using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
	public GameObject cubePrefab;
	public float spawnRange = 10.0f; // Width of spawn area
	public float spawnHeight = 10.0f; // Height above plane
	public float spawnInterval = 2.0f; // Time between spawns
	private float timer;

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;
		if (timer >= spawnInterval)
		{
			SpawnCube();
			timer = 0f;
			// Gradually make spawns faster
			if (spawnInterval > 0.5f)
				spawnInterval -= 0.05f;
		}
	}

	void SpawnCube()
	{
		Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), spawnHeight,
		Random.Range(-spawnRange, spawnRange));
		Instantiate(cubePrefab, spawnPos, Quaternion.identity);
	}
}
