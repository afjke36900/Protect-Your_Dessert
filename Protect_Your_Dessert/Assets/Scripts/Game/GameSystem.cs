using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public GameObject pause;
    #region 遊戲時間與倒數
    [Header("倒數時間")]
    public Text textTime; //畫面上呈現的倒數時間
    private float gameTime = 10; //遊戲秒數
    #endregion

    #region 結束畫面
    [Header("結束畫面標題")]
    public Text textTitle;
    [Header("結束畫面")]
    public CanvasGroup final;
    #endregion

    private void CountTime()  //倒數時間方法
    {
        gameTime -= Time.deltaTime;

        //遊戲時間 = 數學.夾住(遊戲時間,最小值,最大值) <--不知道幹嘛用的
        gameTime = Mathf.Clamp(gameTime, 0, 100);

        textTime.text = "倒數時間:" + gameTime.ToString("f0");

        GameOver();

    }

    private void GameOver() //遊戲結束方法
    {
        if (gameTime == 0)
        {
            //顯示結束畫面，啟動互動、啟動遮擋 (初始alpha設定=0)
            final.alpha = 1;
            final.interactable = true;
            final.blocksRaycasts = true;
            textTitle.text = "Game Over";
            FindObjectOfType<Controller>().enabled = false;
            FindObjectOfType<Shooting>().enabled = false;
        }
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
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
        FindObjectOfType<GameManager>().enabled = false;
    }

    public void ChooseLevel()
    {
        SceneManager.LoadScene("Level");
    }

    private void Update()
    {
        CountTime();
    }
}
