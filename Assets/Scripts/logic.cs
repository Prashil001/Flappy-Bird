using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public AudioSource GameOverSound;
    public GameObject panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int Scoring = 0;
    public Text Score;
    public PipeSpawn ps;
    void Start()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("Flappy");
    }
    public void addscore()
    {
        Scoring = Scoring + 1;
        Score.text = Scoring.ToString();
    }
    public void gameOver()
    {
        panel.SetActive(true);
        ps.enabled = false;
        GameOverSound.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
