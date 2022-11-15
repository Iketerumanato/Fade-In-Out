using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IconMove : MonoBehaviour
{
    //�A�C�R���̃X�s�[�h
    [SerializeField] private float speed_Ic;
    [SerializeField] private float speed_sc;

    //�㉺�̈ړ�����
    [SerializeField] private float maxY;
    [SerializeField] private float minY;

    //���E�̈ړ�����
    [SerializeField] private float maxX;
    [SerializeField] private float minX;

    //�}�b�v�̑I���ƃX�N���[�����s��
    public GameObject Map;
    public int StageNum ;

    float p_red, p_blue, p_green, p_alfa;
    Image panel;

    void Start()
    {
        //if (PlayerPrefs.Getint("Init") != 1)
        //{

        //}

        //StageNum = PlayerPrefs.GetInt("Stage", 1);
        panel = GetComponent<Image>();
        p_red = panel.color.r;
        p_green = panel.color.g;
        p_blue = panel.color.b;
        p_alfa = panel.color.a;
    }


    // Update is called once per frame
    void Update()
    {

        fadeIn();
        Move();

        //ChangeScene();
        
        //��
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    PlayerPrefs.SetInt("Stage",2);
        //    PlayerPrefs.Save();
        //}
    }

    void Move()
    {
        //���̍��W
        Vector2 Iconpos = transform.position;

        Vector2 Mappos = Map.transform.position;

        //��L�[����
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Iconpos.y += speed_Ic;

            //�����Ƀ}�b�v���X�N���[��
            if (Mappos.y > -18.5f)
            {
                Mappos.y -= speed_sc;
            }
        }

        //���L�[����
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Iconpos.y -= speed_Ic;

            if (Mappos.y < 510f)
            {
                Mappos.y += speed_sc;
            }
        }

        //�E�L�[����
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Iconpos.x += speed_Ic;
        }

        //���L�[����
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Iconpos.x -= speed_Ic;
        }

        //�㉺�̈ړ�����
        Iconpos.y = Mathf.Clamp(Iconpos.y, minY, maxY);

        //���E�̈ړ�����
        Iconpos.x = Mathf.Clamp(Iconpos.x, minX, maxX);

        //���݂̍��W�̕ۑ�
        transform.position = Iconpos;
        Map.transform.position = Mappos;

        //�R���\�[���ł̕\��
        //Debug.Log(Mappos.y);
    }

    //�A�C�R�����X�e�[�W�ՂɐG��Ă���Ԃ̏���
    private void OnTriggerStay2D(Collider2D other)
    {
        //�V�[���̈ړ�

        //1
        if (other.gameObject.CompareTag("Stage1"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadSceneAsync("Stage1");
            }

            StageNum = 1;
            Debug.Log("Stage1");
        }

        //2
        if (other.gameObject.CompareTag("Stage2"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadSceneAsync("Stage2");
            }

            StageNum = 2;
            Debug.Log("Stage2");
        }

        //3
        if (other.gameObject.CompareTag("Stage3"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadSceneAsync("Stage3");
            }

            StageNum = 3;
            Debug.Log("Stage3");
        }

        //4
        if (other.gameObject.CompareTag("Stage4"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadSceneAsync("Stage4");
            }

            StageNum = 4;
            Debug.Log("Stage4");
        }

        //5
        if (other.gameObject.CompareTag("Stage5"))
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadSceneAsync("Stage5");
            }

            StageNum = 5;
            Debug.Log("Stage5");
        }

        if (other.gameObject.CompareTag("Stage10"))
        {
            //if (Input.GetKey(KeyCode.Escape))
            //{   
            //    //�Q�[���v���C�I��
            //    UnityEditor.EditorApplication.isPlaying = false;
            //    Application.Quit();
            //}

            //StageNum = 10;
            //Debug.Log("Escape to GameEnd");
        }
    }

    void fadeIn()
    {
        p_alfa -= 0.003f;                
        Alpha();                      
        {                   
            panel.enabled = false;
        }
    }
    void Alpha()
    {
        panel.color = new Color(p_red, p_green, p_blue, p_alfa);
    }
}
