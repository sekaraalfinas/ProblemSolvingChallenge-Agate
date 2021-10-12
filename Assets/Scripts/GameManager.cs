using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Menambah jumlah cube yang dimiliki
    public int score;
    public Text scoreText;

    // Game Over Panel
    public GameObject gameOverPanel;

    private void Awake()
    {
        gameOverPanel.SetActive(false);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void OnEnemyHit()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        score = 0;
        scoreText.text = "0";

        Destroy(GameObject.FindGameObjectWithTag("cube"));
        GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0, 0, 0);
        GameObject.FindGameObjectWithTag("Enemy").transform.position = new Vector3(-3, 0, 0);

        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
