using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PushChangeScene : MonoBehaviour
{
    //押すとセレクト画面に戻る
    public void OnClickButton()
    {
        //Application.LoadLevel("Stage1");

        SceneManager.LoadScene("SelectScene");

        Time.timeScale = 1f;
    }
}
