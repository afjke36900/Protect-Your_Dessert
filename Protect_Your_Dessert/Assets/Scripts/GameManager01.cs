using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager01 : MonoBehaviour
{
    #region 切換場景

    // 新遊戲
    public void NewGame()
    {
        SceneManager.LoadScene("Level");
    }

    // 繼續遊戲
    public void ContinueGame()
    {
        SceneManager.LoadScene("Game");
    }

    // 重新遊戲
    public void Replay()
    {
        SceneManager.LoadScene("Game");
    }

    // 設定
    public void Set()
    {
        SceneManager.LoadScene("Set");
    }

    // 遊戲控制
    public void GameControl()
    {
        SceneManager.LoadScene("GameControl");
    }

    // 返回首頁
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    // 離開遊戲
    public void Quit()
    {
        Application.Quit();
    }
    #endregion
}
