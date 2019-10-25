using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGirl : MonoBehaviour
{
    public Sprite RocketGirlImage;
    public Sprite PayloadGirlImage;
    public Sprite DebrisGirlImage;

    Image debrisImage;

    string DebrisType;

    // Start is called before the first frame update
    void Start()
    {
       DebrisType = State.GetCollDebrisType();
       debrisImage = this.GetComponent<Image>();

        if (DebrisType == "DEBRIS")
        {
            debrisImage.sprite = DebrisGirlImage;
        }
        else if (DebrisType == "PAYLOAD")
        {
            debrisImage.sprite = PayloadGirlImage;
        }
        else if(DebrisType=="ROCKET BODY")
        {
            debrisImage.sprite = RocketGirlImage;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
