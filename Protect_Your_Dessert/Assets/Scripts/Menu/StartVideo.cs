using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class StartVideo : MonoBehaviour
{
    public VideoPlayer Movie_;
    float Timer;
    void Start()
    {
        InvokeRepeating("CheckMovie", 3f, 0.1f);
    }


    void CheckMovie()
    {
        if (Movie_.isPlaying == false)
        {
            SceneManager.LoadScene("Player Control Test");
        }
    }
}
