using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RocketController : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject explosionPrefab;

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
        Destroy(coll.gameObject);
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");
    }
}