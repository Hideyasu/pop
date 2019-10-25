using UnityEngine;
using System.Collections;

public class RockController : MonoBehaviour
{

    float fallSpeed_x;
    float fallSpeed_y;
    float rotSpeed;

    string debris_type;
    string debris_name;
    string debris_owner;
    string debris_launch_site;

    void Start()
    {
        this.fallSpeed_x = 0.01f + 0.1f * (Random.value-0.5f)*2;
        this.fallSpeed_y = 0.01f + 0.1f * Random.value;
        this.rotSpeed = 5f + 3f * Random.value;
    }

    void Update()
    {
        transform.Translate(-fallSpeed_x, -fallSpeed_y, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);

        if (transform.position.x < -12.0f
            || transform.position.x > 12.0f
            || transform.position.y < -5.5f
            || transform.position.y > 7.5f)
        {
            Destroy(gameObject);
        }
    }

    public void SetDebrisType(string dt)
    {
        debris_type = dt;
    }

    public string GetDebrisType()
    {
        return debris_type;
    }

    public void SetDebrisName(string dt)
    {
        debris_name = dt;
    }

    public string GetDebrisName()
    {
        return debris_name;
    }

    public void SetDebrisOwner(string dt)
    {
        debris_owner = dt;
    }

    public string GetDebrisOwner()
    {
        return debris_owner;
    }

    public void SetDebrisLanchSite(string dt)
    {
        debris_launch_site = dt;
    }

    public string GetDebrisLaunchSite()
    {
        return debris_launch_site;
    }



}