using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public int score = 0;
    GameObject scoreText;
    GameObject gameOverText;

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
    }
    public void AddScore()
    {
        this.score += 10;
    }
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text> ().text = "score:" + score.ToString("D4");
    }
}
