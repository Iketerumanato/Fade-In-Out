using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePause : MonoBehaviour
{
    [SerializeField] private GameObject PauseUI;
    [SerializeField] private GameObject Retry;
    [SerializeField] private GameObject Select;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Uiとボタンたちを起こす
            PauseUI.SetActive(!PauseUI.activeSelf);
            Retry.SetActive(!Retry.activeSelf);
            Select.SetActive(!Select.activeSelf);

            //押すと一時停止
            if (PauseUI.activeSelf)
            {
                Time.timeScale = 0f;
            }
        }
    }
}
