using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndSceneVideo : MonoBehaviour
{
    public VideoPlayer LoseVideo;
    public VideoPlayer WinVideo;
    public GameObject backgrond;
    public CanvasGroup EndPage;

    void Start()
    {        
        InvokeRepeating("PlayWinMovie", 3f, 0.1f);
        InvokeRepeating("PlayLoseMovie", 3f, 0.1f);
        Invoke("DestroyBackground", 0.7f);
    }
    private void WinorLose()
    {
        if (GameSystem.winorlose = false)
        {
            Destroy(WinVideo);
            PlayLoseMovie();
        }
        else if (GameSystem.winorlose = true)
        {
            Destroy(LoseVideo);
            PlayWinMovie();
        }
    }

    void PlayLoseMovie()
    {
        if (LoseVideo.isPlaying == false)
        {
            EndPage.alpha = 1;
            EndPage.interactable = true;
            EndPage.blocksRaycasts = true;
        }
    }
    void PlayWinMovie()
    {
        if (WinVideo.isPlaying == false)
        {
            EndPage.alpha = 1;
            EndPage.interactable = true;
            EndPage.blocksRaycasts = true;
        }
    }

    void DestroyBackground()
    {
        Destroy(backgrond);
    }

    public void BackToLevel()
    {
        SceneManager.LoadScene("Level");
    }
    public void Restart()
    {
        SceneManager.LoadScene(GameSystem.currentScene);
    }



}

