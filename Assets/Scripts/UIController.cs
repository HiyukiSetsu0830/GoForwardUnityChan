using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    //�Q�[���I�[�o�[�e�L�X�g
    private GameObject gameOverText;
    //���s�����e�L�X�g
    private GameObject runLengthText;
    //����������
    private float len = 0;
    //���鑬�x
    private float speed = 5f;
    //�Q�[���I�[�o�[�̔���
    private bool isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {

        //�V�[���r���[����I�u�W�F�N�g�̎��̂���������
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");


    }

    // Update is called once per frame
    void Update()
    {
        bool isSceneLoad = Input.GetMouseButtonDown(0);
        if (this.isGameOver == false) RunLengthUpdate();
        if (this.isGameOver == true)
        if (isSceneLoad) SceneManager.LoadScene("SampleScene");
            
    }

    private void RunLengthUpdate() {

        //�������������X�V����
        this.len += this.speed * Time.deltaTime;
        //������������\������
        this.runLengthText.GetComponent<Text>().text = "Distance: " + len.ToString("F2") + "m";

    }

    /// <summary>
    /// �Q�[���I�[�o�[����
    /// </summary>
    public void GameOver() {

        //�Q�[���I�[�o�[�ɂȂ����Ƃ��ɁA��ʏ�ɃQ�[���I�[�o�[��\������
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }
}
