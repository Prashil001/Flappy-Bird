using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class homeScreenManagement : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
