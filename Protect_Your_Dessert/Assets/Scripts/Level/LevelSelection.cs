using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    
    public Button[] levelbutton= new Button[9];
    /// <summary>
    /// 當前關卡
    /// </summary>
    static public int NowLevel = 0;

    //開始遊戲
    public void StartGame()
    {
        SceneManager.LoadScene("StartStory");
        Destroy(GameObject.FindGameObjectWithTag("BGM1"));
    }

    //回到首頁
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
        Destroy(GameObject.FindGameObjectWithTag("BGM1"));
    }

    //點選關卡
    public void PressSelection(string _LevelName)
    {
        SceneManager.LoadScene(_LevelName);
        Destroy(GameObject.FindGameObjectWithTag("BGM1"));
    }

    /// <summary>
    /// 關卡解鎖
    /// </summary>
    /// <param name="i"></param>
    /*private void UpdateLevelImage(int i)
    {
        //如果關卡圖片是"未通關"
        if (levelbutton[i].image.sprite.name== "LevelUI_NotClear")
        {
            //關卡不能點擊
            levelbutton[i+1].interactable = false;
        }
        else if (levelbutton[i].image.sprite.name == "LevelUI_Clear")
        { 
            levelbutton[i+1].interactable = true;
        }
    }*/
    private void UpdateLevelImage()
    {
        levelbutton[NowLevel].interactable = true;
    }





}
