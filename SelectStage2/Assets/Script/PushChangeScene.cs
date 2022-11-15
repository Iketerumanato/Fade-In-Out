using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PushChangeScene : MonoBehaviour
{
    //‰Ÿ‚·‚ÆƒZƒŒƒNƒg‰æ–Ê‚É–ß‚é
    public void OnClickButton()
    {
        //Application.LoadLevel("Stage1");

        SceneManager.LoadScene("SelectScene");

        Time.timeScale = 1f;
    }
}
