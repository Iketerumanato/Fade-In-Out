using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMove : MonoBehaviour
{
    public float speed_chara = 0.1f;

    // Update is called once per frame
    //�|�[�Y�@�\�m�F�̂��ߓ������Ƃ�
    void Update()
    {
        transform.position += new Vector3(speed_chara * Time.deltaTime, 0);
    }
}
