using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    //unity内のimage
    [SerializeField] private Image StageName;
    //表示するステージ名
    [SerializeField] private Sprite Stage1name;
    [SerializeField] private Sprite Stage2name;
    [SerializeField] private Sprite Stage3name;
    [SerializeField] private Sprite Stage4name;
    [SerializeField] private Sprite Stage5name;

    private GameObject PlayerIc;
    private IconMove iconmove;

    // Start is called before the first frame update
    void Start()
    {
        StageName = GameObject.Find("StageName").GetComponent<Image>();
        StageName.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        NameChange();
    }

    void NameChange()
    {
        PlayerIc = GameObject.Find("PlayerCarsol");
        iconmove = PlayerIc.GetComponent<IconMove>();

        //IconMove内の変数で名前を切り替える
        if (iconmove.StageNum == 1)
        {
            StageName.sprite = Stage1name;
        }

        if (iconmove.StageNum == 2)
        {
            StageName.sprite = Stage2name;
        }

        if (iconmove.StageNum == 3)
        {
            StageName.sprite = Stage3name;
        }

        if (iconmove.StageNum == 4)
        {
            StageName.sprite = Stage4name;
        }

        if (iconmove.StageNum == 5)
        {
            StageName.sprite = Stage5name;
        }
    }
}
