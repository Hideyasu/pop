using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{
    GameObject scoreText;

    public static int Score=0;

    public void AddScore()
    {
        Score += 10;
    }

    void Start()
    {
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