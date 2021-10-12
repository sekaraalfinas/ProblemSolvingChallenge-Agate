using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Menambah jumlah cube yang dimiliki
    public int score;
    public Text scoreText;

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
