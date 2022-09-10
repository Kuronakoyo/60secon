using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Click : MonoBehaviour
{
    public GameObject score_object = null ; // Text�I�u�W�F�N�g
    public static int score_num = 1;
    private float time = 60f;
    public Text timerText;
    public bool isTimeUp;
    public void SelectTextA()
    {
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "��������:" + score_num;

        score_num += 1; // �Ƃ肠����1���Z�������Ă݂�
    }
    public static int getscore()
    {
        return score_num;
    }
    // Use this for initialization
    void Start()
    {
        isTimeUp = false;
        score_num = 0;
    }
    void Update()
    {
        
        if (0 < time)
        {
            time -= Time.deltaTime;
            timerText.text = "TIME:" + time.ToString("F1");
        }
        else if (time <= 0)
        {
            isTimeUp = true;
            SceneManager.LoadScene("result");
        }
    }
}
