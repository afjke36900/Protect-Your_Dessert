using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager01 : MonoBehaviour
{
    #region 切換場景

    // 新遊戲
    public void Level()
    {
        SceneManager.LoadScene("Level");
    }

    // 繼續遊戲
    public void ContinueGame()
    {
        SceneManager.LoadScene("Player Control Test");
    }

    // 重新遊戲
    public void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Player Control Test");
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
