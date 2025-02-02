﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.PlayerLoop;

public class GameSystem : MonoBehaviour
{
    public GameObject pause;
    #region 遊戲時間與倒數
    [Header("倒數時間")]
    public Text textTime; //畫面上呈現的倒數時間
    private float gameTime = 20; //遊戲秒數
    #endregion
    #region 計算材質數量
    [Header("牆壁材質")]
    public GameObject[] wall_material;

    public List<Material> WallM = new List<Material>();
    #endregion

    #region 結束畫面
    [Header("結束畫面")]
    public CanvasGroup final;
    public static bool winorlose;
    #endregion

    public static int currentScene;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void CountTime()  //倒數時間方法
    {
        gameTime -= Time.deltaTime;

        //遊戲時間 = 數學.夾住(遊戲時間,最小值,最大值) <--不知道幹嘛用的
        gameTime = Mathf.Clamp(gameTime, 0, 100);

        textTime.text =gameTime.ToString("f0");

        GameOver();

    }

    private void GameOver() //遊戲結束方法
    {
        if (gameTime == 0)
        {
            for (int i = 0; i < wall_material.Length; i++)
        {
            WallM.Add(wall_material[i].GetComponent<MeshRenderer>().material);
        }
        var not_cover = WallM.Where(x => x.color == new Color32(255, 255, 255, 0));
        int a = not_cover.ToList().Count;
            WallM.Clear();
            if (a< 10)
            { 
            //顯示結束畫面，啟動互動、啟動遮擋 (初始alpha設定=0)
            final.alpha = 1;
            final.interactable = true;
            final.blocksRaycasts = true;
            FindObjectOfType<Controller>().enabled = false;
            FindObjectOfType<Shooting>().enabled = false;
                winorlose = false;
                print(winorlose);
            Invoke("EndScene", 3f);
            }
        else if (a>10)
        {
            //顯示結束畫面，啟動互動、啟動遮擋 (初始alpha設定=0)
            final.alpha = 1;
            final.interactable = true;
            final.blocksRaycasts = true;
            FindObjectOfType<Controller>().enabled = false;
            FindObjectOfType<Shooting>().enabled = false;
                winorlose = true;
                print(winorlose);
            Invoke("EndScene", 3f);
        }
        }
    }

    private void EndScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
        FindObjectOfType<Controller>().enabled = false;
        FindObjectOfType<Shooting>().enabled = false;
    }

    public void ReturnGame()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
        FindObjectOfType<Controller>().enabled = true;
        FindObjectOfType<Shooting>().enabled = true;
    }

    // 返回首頁
    public void Level()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level");
        FindObjectOfType<GameManager>().enabled = false;
    }

    public void ChooseLevel()
    {
        SceneManager.LoadScene("Level");
        LevelSelection.NowLevel++;
    }

    private void Update()
    {
        CountTime();
    }
}
