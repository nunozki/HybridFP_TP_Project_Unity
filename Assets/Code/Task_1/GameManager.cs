using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance;
	public int score = 0;
	public float survivalTime = 0.0f;
	public bool isGameOver = false;

	void Awake()
	{
		if (Instance == null)
			Instance = this;
	}

	// Update is called once per frame
	void Update()
	{
		if (!isGameOver)
		{
			survivalTime += Time.deltaTime;
		}
	}
	public void AddScore(int value)
	{
		score += value;
	}
	public void GameOver()
	{
		isGameOver = true;
		Debug.Log("Game Over! Final Score: " + score + " | Time: " + survivalTime);
	}
}
