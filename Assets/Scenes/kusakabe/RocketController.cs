using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RocketController : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject explosionPrefab;
    GameObject StateObj;
    string collDebrisType;
    string collDebrisName;
    string collDebrisOwner;
    string collDebrisLaunchSite;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0.1f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,-0.1f,0);
        }
    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        //衝突オブジェクトのスクリプトにアクセス
        RockController c = coll.gameObject.GetComponent<RockController>();
        collDebrisType = c.GetDebrisType();
        collDebrisName = c.GetDebrisName();
        collDebrisOwner = c.GetDebrisOwner();
        collDebrisLaunchSite = c.GetDebrisLaunchSite();

        Debug.Log("coll obj:"+collDebrisType);

        //衝突オブジェクトを記録
      
        State.SetCollDebrisType(collDebrisType);
        State.SetCollDebrisName(collDebrisName);
        State.SetCollDebrisOwner(collDebrisOwner);
        State.SetCollDebrisLaunchSite(collDebrisLaunchSite);


        //衝突オブジェクトと自機を破壊
        Destroy(coll.gameObject);
        Destroy(gameObject);

        //ゲームオーバーシーンに遷移
        SceneManager.LoadScene("GameOver");
    }

    public string GetCollDebrisType()
    {
        return collDebrisType;
    }
}