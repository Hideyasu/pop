using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryController : MonoBehaviour
{
    public GameObject window1;
    public GameObject window2;
    private void Start()
    {
        window1 = GameObject.Find("Window1");
        window2 = GameObject.Find("Window2");
        window1.SetActive(true);
        window2.SetActive(false);
    }

    public void showWindow1() {
        window1.SetActive(true);
        window2.SetActive(false);
    }

   public void showWindow2()
    {
        window1.SetActive(false);
        window2.SetActive(true);
    }

    public void deleteWindow2()
    {
        Destroy (window2);
    }
}
