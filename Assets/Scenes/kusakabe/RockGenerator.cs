using UnityEngine;
using System.Collections;

[System.Serializable]
public class Debris
{
    public DebrisParameter[] DEBRIS;
}
[System.Serializable]
public class DebrisParameter
{
    public string OBJECT_ID;
    public string OBJECT_NAME;
    public string NORAD_CAT_ID;
    public string OBJECT_TYPE;
    public string PERIOD;
    public string INCLINATION;
    public string APOGEE;
    public string PERIGEE;
    public string ECCENTRICITY;
    public string MEAN_MOTION;
    public string TLE_LINE1;
    public string TLE_LINE2;
    public string LAUNCH_DATE;
    public string LAUNCH_SITE;
    public string OWNER;
    public string ORBIT_TYPE;
    public string OPERATIONAL_STATUS;
}


public class RockGenerator : MonoBehaviour
{
    float position;
    float pos_x;
    float pos_y;

    public GameObject rockPrefab;
    public GameObject payloadPrefab;
    public GameObject rocketPrefab;

    GameObject Prefab;

    int Debris_ID;
    string Debris_type;
    string Debris_name;
    string Debris_owner;
    string Debris_launch_site;
    public int debrisLength = 15000;
    Debris debrises;

    void Start()
    {
        InvokeRepeating("GenRock", 1, 0.1f);
        // jsopnの読み込み
        TextAsset textasset = new TextAsset();
        textasset = Resources.Load("deb", typeof(TextAsset)) as TextAsset;
        debrises = JsonUtility.FromJson<Debris>(textasset.text);
        //Debug.Log("Launch site:"+debrises.DEBRIS[1].LAUNCH_SITE);
        //Debug.Log("Object name:" + debrises.DEBRIS[1].OBJECT_NAME);
        //Debug.Log("period:" + debrises.DEBRIS[1].PERIOD);
        //Debug.Log("owner:" + debrises.DEBRIS[1].OWNER);


        //Debug.Log(debrises.DEBRIS.Length);
        this.Debris_ID = Mathf.FloorToInt(Random.value * debrises.DEBRIS.Length);
        this.Debris_type = debrises.DEBRIS[this.Debris_ID].OBJECT_TYPE;
        this.Debris_name = debrises.DEBRIS[this.Debris_ID].OBJECT_NAME;
        this.Debris_owner = debrises.DEBRIS[this.Debris_ID].OPERATIONAL_STATUS;
        this.Debris_launch_site = debrises.DEBRIS[this.Debris_ID].LAUNCH_SITE;


        //Debug.Log(Debris_type);

        InvokeRepeating("GenPay", 1, 5.0f);
    }

    void GenRock()
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

        else if(position < 40.0f)//右から出現
        {
            this.pos_x = 10.0f;
            this.pos_y = this.position - 30.0f;
        }

        else//下から出現
        {
            this.pos_x = this.position - 40.0f;
            this.pos_y = -6.0f;
        }

        Debris_ID = Mathf.FloorToInt(Random.value * debrisLength);
        Debris_type = debrises.DEBRIS[this.Debris_ID].OBJECT_TYPE;

        if (Debris_type == "PAYLOAD")
        {
            Prefab = payloadPrefab;
        }
        else if (Debris_type == "DEBRIS")
        {
            Prefab = rockPrefab;
        }
        else if (Debris_type == "ROCKET BODY")
        {
            Prefab = rocketPrefab;
        }

        GameObject controller = Instantiate(Prefab, new Vector3(pos_x, pos_y, 0), Quaternion.identity);

        //RockControllerインスタンス作る　スクリプトにアクセス
        RockController c = controller.GetComponent<RockController>();
        c.SetDebrisType(Debris_type);
        c.SetDebrisName(Debris_name);
        c.SetDebrisOwner(Debris_owner);
        c.SetDebrisLanchSite(Debris_launch_site);
    }

}