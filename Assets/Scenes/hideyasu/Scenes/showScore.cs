using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showScore : MonoBehaviour
{
	int result_score = 0;
    GameObject result_scoreText;

    void Start()
    {
        result_score = UIController.GetScore();
        result_scoreText = GameObject.Find("result_score");
        result_scoreText.GetComponent<Text>().text = "Score:" + result_score.ToString("D4");
        Debug.Log("score");
        Debug.Log(result_score);
    }
}