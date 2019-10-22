using UnityEngine;
using System.Collections;

public class PayloadGenerator : MonoBehaviour
{
    float position;
    float pos_x;
    float pos_y;

    public GameObject payloadPrefab;

    void Start()
    {
        InvokeRepeating("GenPay", 1, 5.0f);
    }

    void GenPay()
    {
        this.position = Random.value * 60.0f;
        if (this.position < 10.0f)//左から出現
        {
            this.pos_x = -10.0f;
            this.pos_y = this.position;
        }

        else if (position < 30.0f)//上から出現
        {
            this.pos_x = this.position - 10.0f;
            this.pos_y = 5.0f;
        }

        else if (position < 40.0f)//右から出現
        {
            this.pos_x = 10.0f;
            this.pos_y = this.position - 30.0f;
        }

        else//下から出現
        {
            this.pos_x = this.position - 40.0f;
            this.pos_y = -6.0f;
        }

        Instantiate(payloadPrefab, new Vector3(pos_x, pos_y, 0), Quaternion.identity);
    }


}