using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    private GameObject player;
    private SnakeController snake;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        snake = player.GetComponent<SnakeController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            snake.AddPart();
            SpawnManager.Instance.Spawn(this.gameObject);
            GameManager.Instance.score++;
            EventManager.Fire_onScoreChanged(GameManager.Instance.score);
            Destroy(this.gameObject);
        }
    }
}
