using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartController : MonoBehaviour
{
    bool push = false;

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
    }
}
