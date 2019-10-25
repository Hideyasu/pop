using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    GameObject StateObj;
    static string CollDebrisType;
    static string CollDebrisName;
    static string CollDebrisOwner;
    static string CollDebrisLaunchSite;

    void Start()
    {
        StateObj = GameObject.Find("State");
    }


    public static void SetCollDebrisType(string dt)
    {
        CollDebrisType = dt;
    }

    public static string GetCollDebrisType()
    {
        return CollDebrisType;
    }


    public static void SetCollDebrisName(string dt)
    {
        CollDebrisName = dt;
    }

    public static string GetCollDebrisName()
    {
        return CollDebrisName;
    }

    public static void SetCollDebrisOwner(string dt)
    {
        CollDebrisOwner = dt;
    }

    public static string GetCollDebrisOwner()
    {
        return CollDebrisOwner;
    }

    public static void SetCollDebrisLaunchSite(string dt)
    {
        CollDebrisLaunchSite = dt;
    }

    public static string GetCollDebrisLaunchSite()
    {
        return CollDebrisLaunchSite;
    }



}
