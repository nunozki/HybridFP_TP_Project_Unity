using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public Text scoreText;
	public Text timerText;
	public Text gameOverText;

	// Update is called once per frame
	void Update()
	{
		if (GameManager.Instance != null)
		{
			scoreText.text = "Score: " + GameManager.Instance.score;
			timerText.text = "Time: " + Mathf.FloorToInt(GameManager.Instance.survivalTime);
			if (GameManager.Instance.isGameOver)
			{
				gameOverText.gameObject.SetActive(true);
				gameOverText.text = "Game Over!\nFinal Score: " + GameManager.Instance.score +
				"\nTime: " + Mathf.FloorToInt(GameManager.Instance.survivalTime);
			}
		}
	}
}