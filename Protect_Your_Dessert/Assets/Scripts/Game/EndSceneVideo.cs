using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndSceneVideo : MonoBehaviour
{
    public VideoPlayer endVid;
    public AudioSource endAud;
    public VideoClip[] endVideo;
    public GameObject backgrond;
    public CanvasGroup[] EndPage;
    public AudioClip[] endaud;
    public bool a;

    void Start()
    {
        a = GameSystem.winorlose;
        print(GameSystem.winorlose + "Now");
        InvokeRepeating("PlayWinMovie", 3f, 0.1f);
        InvokeRepeating("PlayLoseMovie", 3f, 0.1f);
        Invoke("DestroyBackground", 0.7f);
        WinorLose();
    }

    private void WinorLose()
    {
        if (a == false)
        {
            endAud.GetComponent<AudioSource>().clip = endaud[0];
            endAud.GetComponent<AudioSource>().Play();
            endVid.GetComponent<VideoPlayer>().clip = endVideo[0];
            endVid.GetComponent<VideoPlayer>().Play();
            PlayLoseMovie();
        }
        else if (a== true)
        {
            endAud.GetComponent<AudioSource>().clip = endaud[1];
            endAud.GetComponent<AudioSource>().Play();
            endVid.GetComponent<VideoPlayer>().clip = endVideo[1];
            endVid.GetComponent<VideoPlayer>().Play();
            PlayWinMovie();
        }
    }

    void PlayLoseMovie()
    {
        if (endVid.isPlaying == false)
        {
            EndPage[0].alpha = 1;
            EndPage[0].interactable = true;
            EndPage[0].blocksRaycasts = true;
        }
    }
    void PlayWinMovie()
    {
        if (endVid.isPlaying == false)
        {
            EndPage[1].alpha = 1;
            EndPage[1].interactable = true;
            EndPage[1].blocksRaycasts = true;
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

