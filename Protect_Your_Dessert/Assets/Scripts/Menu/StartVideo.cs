using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class StartVideo : MonoBehaviour
{
    public VideoPlayer Movie_;
    public GameObject backgrond;
    public Text Skipfilm;
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
            SceneManager.LoadScene("Teach");
        }
    }
    void DestroyBackground()
    {
        Destroy(backgrond);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Teach");
        }
    }

}
