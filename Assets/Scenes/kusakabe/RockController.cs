using UnityEngine;
using System.Collections;

public class RockController : MonoBehaviour
{

    float fallSpeed_x;
    float fallSpeed_y;
    float rotSpeed;

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
}