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
            //Ui‚Æƒ{ƒ^ƒ“‚½‚¿‚ð‹N‚±‚·
            PauseUI.SetActive(!PauseUI.activeSelf);
            Retry.SetActive(!Retry.activeSelf);
            Select.SetActive(!Select.activeSelf);

            //‰Ÿ‚·‚ÆˆêŽž’âŽ~
            if (PauseUI.activeSelf)
            {
                Time.timeScale = 0f;
            }
        }
    }
}
