using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager_Button_Click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //ボタンを押した時の処理
    public void Click()
    {
        //ログ出力
        Debug.Log("押したよ！");
    }

    public void GoPlayScene()
    {
        SceneManager.LoadScene("Play");
    }

    public void GoGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void GoGalleryScene()
    {
        SceneManager.LoadScene("Gallery");
    }

    public void GoTopScene()
    {
        SceneManager.LoadScene("Top");
    }

    public void GoSettingScene()
    {
        SceneManager.LoadScene("Setting");
    }
}
