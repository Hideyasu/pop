using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class showScore : MonoBehaviour
{
	int result_score = 0;

    GameObject resultScoreText;
    GameObject debrisTypeText;
    GameObject debrisNameText;
    GameObject debrisOwnerText;
    GameObject debrisLaunchSiteText;

    string debriType;

    void Start()
    {
        result_score = UIController.GetScore();
        resultScoreText = GameObject.Find("result_score");
        resultScoreText.GetComponent<Text>().text = "Score:" + result_score.ToString("D4");
        //Debug.Log("score");
        //Debug.Log(result_score);

        debriType = State.GetCollDebrisType();
        debrisTypeText = GameObject.Find("debris_type");
        debrisTypeText.GetComponent<Text>().text = "Type  " + debriType;
        Debug.Log("Debris Type:"+debriType);

        debrisNameText = GameObject.Find("debris_name");
        debrisNameText.GetComponent<Text>().text = State.GetCollDebrisName();

        debrisOwnerText = GameObject.Find("debris_owner");
        debrisOwnerText.GetComponent<Text>().text = "Owner  " + State.GetCollDebrisOwner();

        debrisLaunchSiteText = GameObject.Find("debris_launch_site");
        debrisLaunchSiteText.GetComponent<Text>().text = "Launch Site  " + State.GetCollDebrisLaunchSite();


    }

}