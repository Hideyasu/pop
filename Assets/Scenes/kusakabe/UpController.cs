using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpController : MonoBehaviour
{
    bool push = false;
    public GameObject rocket;
    public void PushDown()
    {
        push = true;
    }

    public void PushUp()
    {
        push = false;
    }
    void Update()
    {
        if (push)
        {
            Move();
        }
    }
    public void Move()
    {
        rocket.transform.Translate(0, 0.1f, 0);
    }
}
