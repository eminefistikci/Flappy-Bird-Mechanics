using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public GameObject startScene;
    public GameObject endScene;
    public static bool isRestarted=false;
    public bool isEnded = false;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI endScoreText;
    int score;
    void Start()
    {
        if (isRestarted)
        {
            startGame();
            isRestarted = false;
            isEnded = false;

        }
        else
        {
            Time.timeScale = 0;
            scoreText.gameObject.SetActive(false);
            startScene.SetActive(true);
            endScene.SetActive(false);
            isEnded = false;
        }

    }

    public void startGame()
    {
        Time.timeScale = 1;
        scoreText.gameObject.SetActive(true);
        startScene.SetActive(false);
        isEnded = false;
    }

    public void endGame()
    {
        Time.timeScale = 0;
        scoreText.gameObject.SetActive(false);
        endScene.SetActive(true);
        isEnded = true;
        endScoreText.text = score.ToString();
    }

    public void restartGame()
    {
        isRestarted = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isEnded = false;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
