using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{

    private TextMeshProUGUI scoreText,gameOvScore;
    private GameObject GameOverPanel;
    private bool gameOver=false;

    Scene scene;
   

    private void Awake()
    {

        scoreText = transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        GameOverPanel = transform.GetChild(1).gameObject;
        gameOvScore = GameOverPanel.transform.GetChild(1).transform.GetComponent<TextMeshProUGUI>();
    
        scene = SceneManager.GetActiveScene();
    }
    private void Start()
    {
        scoreText.text = "Score : 0";
        GameOverPanel.SetActive(gameOver);
      
    }
  
    public void Restart()
    {
        SceneManager.LoadScene(scene.buildIndex);
        Time.timeScale = 1f;
    }
    private void OnScoreChanged(int score)
    {
        scoreText.text = "Score : " + score;
    }
    private void OnGameOver()
    {
        gameOver = true;
        scoreText.gameObject.SetActive(false);
        GameOverPanel.SetActive(gameOver);
        gameOvScore.text ="Score :"+ GameManager.Instance.score;
    }
    private void OnEnable()
    {
        EventManager.onGameOver += OnGameOver;
        EventManager.onScoreChanged += OnScoreChanged;
    }
    private void OnDisable()
    {
        EventManager.onScoreChanged -= OnScoreChanged;

        EventManager.onGameOver -= OnGameOver;

    }
}
