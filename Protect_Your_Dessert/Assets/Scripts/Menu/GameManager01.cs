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

    public void StartGame()
    {
        SceneManager.LoadScene("StartStory");
        Destroy(GameObject.FindGameObjectWithTag("BGM1"));
    }

    // 繼續遊戲
    public void ContinueGame()
    {
        SceneManager.LoadScene("Player Control Test");
        Destroy(GameObject.FindGameObjectWithTag("BGM1"));
    }

    // 重新遊戲
    public void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Player Control Test");
        Destroy(GameObject.FindGameObjectWithTag("BGM1"));
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
        Destroy(GameObject.FindGameObjectWithTag("BGM1"));
    }

    // 離開遊戲
    public void Quit()
    {
        Application.Quit();
    }
    #endregion
}
