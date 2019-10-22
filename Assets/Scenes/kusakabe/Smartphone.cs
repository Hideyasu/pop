using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smartphone : MonoBehaviour
{
    public GameObject up;
    public GameObject right;
    public GameObject left;
    public GameObject down;
    private void Start()
    {
        up = GameObject.Find("Btn_Up");
        right = GameObject.Find("Btn_Right");
        left = GameObject.Find("Btn_Left");
        down = GameObject.Find("Btn_Down");
    }

    public void onUp()
    {
        transform.Translate(0, 0.1f, 0);
    }
    public void onRight()
    {
        transform.Translate(0.1f, 0, 0);
    }
    public void onLeft()
    {
        transform.Translate(-0.1f, 0, 0);
    }
    public void onDown()
    {
        transform.Translate(0, -0.1f, 0);
    }
}
