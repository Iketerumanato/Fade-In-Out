using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeImage : MonoBehaviour
{
    //ステージのイメージ画面の表示
    //名前の表示と同じ

    [SerializeField] private Image StageImage;
    [SerializeField] private Sprite Stage1;
    [SerializeField] private Sprite Stage2;
    [SerializeField] private Sprite Stage3;
    [SerializeField] private Sprite Stage4;
    [SerializeField] private Sprite Stage5;

    //bool[] Imagebool = new bool[3];

    private GameObject PlayerIc;
    private IconMove iconmove;

    // Start is called before the first frame update
    void Start()
    {
        StageImage = GameObject.Find("StageImage").GetComponent<Image>();
        StageImage.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
       ImageChange();
    }


    void ImageChange()
    {
        PlayerIc = GameObject.Find("PlayerCarsol");
        iconmove = PlayerIc.GetComponent<IconMove>();

        if (iconmove.StageNum == 1)
        {
            StageImage.sprite = Stage1;
        }

        if (iconmove.StageNum == 2)
        {
            StageImage.sprite = Stage2;
        }

        if (iconmove.StageNum == 3)
        {
            StageImage.sprite = Stage3;
        }

        if (iconmove.StageNum == 4)
        {
            StageImage.sprite = Stage4;
        }

        if (iconmove.StageNum == 5)
        {
            StageImage.sprite = Stage5;
        }
    }
}
