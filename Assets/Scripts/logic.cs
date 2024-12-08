using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public Text txt;
    public int playerScore = 0;
    public GameObject gameOverScreen;
    public Text gameoverScore;
    public AudioSource gameMusic;

    public void addScore(int score)
    {
        playerScore += score;
        txt.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void overScreen()
    {
        gameoverScore.text = txt.text;
        gameOverScreen.SetActive(true);
        gameMusic.Stop();

    }
    public void homeScreen()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
