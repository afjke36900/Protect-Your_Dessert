using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class TitleName : MonoBehaviour
{
    public VideoPlayer Movie_;
    public GameObject backgrond;
    float Timer;
    void Start()
    {
        InvokeRepeating("CheckMovie", 3f, 0.1f);
        Invoke("DestroyBackground", 0.7f);
    }


    void CheckMovie()
    {
        if (Movie_.isPlaying == false)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    void DestroyBackground()
    {
        Destroy(backgrond);
    }
}
