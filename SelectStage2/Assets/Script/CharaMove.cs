using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMove : MonoBehaviour
{
    public float speed_chara = 0.1f;

    // Update is called once per frame
    //ポーズ機能確認のため動かしとく
    void Update()
    {
        transform.position += new Vector3(speed_chara * Time.deltaTime, 0);
    }
}
