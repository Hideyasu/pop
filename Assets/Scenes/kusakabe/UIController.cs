using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{
    GameObject scoreText;

    public static int Score;

    public void AddScore()
    {
        Score += 10;
    }

    void Start()
    {
        Score = 0;
        this.scoreText = GameObject.Find("Score");
    }

    void Update()
    {
        AddScore();
        scoreText.GetComponent<Text>().text =  Score.ToString("D4");
    }

    public static int GetScore()
    {
        return Score;
    }

    
}