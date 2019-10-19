using UnityEngine;
using System.Collections;

public class RockGenerator : MonoBehaviour
{
    float position;
    float pos_x;
    float pos_y;
    
    public GameObject rockPrefab;

    void Start()
    {
        InvokeRepeating("GenRock", 1, 0.1f);
    }

    void GenRock()
    {
        this.position = Random.value * 40.0f;
        if (this.position < 10.0f)
        {
            this.pos_x = -10.0f;
            this.pos_y = this.position;
        }

        else if (position < 30.0f)
        {
            this.pos_x = this.position - 10.0f;
            this.pos_y = 5.0f;
        }

        else
        {
            this.pos_x = 10.0f;
            this.pos_y = this.position - 30.0f;
        }

        Instantiate(rockPrefab, new Vector3(pos_x,pos_y, 0), Quaternion.identity);
    }


}