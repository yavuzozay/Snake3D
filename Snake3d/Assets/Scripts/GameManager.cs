using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    public int score=0;
  public void GameOver()
    {
        score = 0;
        Time.timeScale = 0f;
    }
    private void OnEnable()
    {
        EventManager.onGameOver += GameOver;
    }
    private void OnDisable()
    {
        EventManager.onGameOver -= GameOver;

    }

}
