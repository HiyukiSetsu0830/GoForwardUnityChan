using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    //ゲームオーバーテキスト
    private GameObject gameOverText;
    //走行距離テキスト
    private GameObject runLengthText;
    //走った距離
    private float len = 0;
    //走る速度
    private float speed = 5f;
    //ゲームオーバーの判定
    private bool isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {

        //シーンビューからオブジェクトの実体を検索する
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

        //走った距離を更新する
        this.len += this.speed * Time.deltaTime;
        //走った距離を表示する
        this.runLengthText.GetComponent<Text>().text = "Distance: " + len.ToString("F2") + "m";

    }

    /// <summary>
    /// ゲームオーバー処理
    /// </summary>
    public void GameOver() {

        //ゲームオーバーになったときに、画面上にゲームオーバーを表示する
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }
}
