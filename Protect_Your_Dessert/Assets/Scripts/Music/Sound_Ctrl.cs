using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Ctrl : MonoBehaviour
{
    bool ControlSound = false;
    [Header("聲音的按鈕圖")]
    public Image SoundButtonImage;
    [Header("聲音的開啟圖")]
    public Sprite OpenImage;
    [Header("聲音的關閉圖")]
    public Sprite CloseImage;
    [Header("聲音拉霸")]
    public Slider SoundSlider;

    private void Start()
    {
        SoundButton();
        SoundSlider.value = 0.5f;
        AudioListener.volume = SoundSlider.value;        
    }

    private void Update()
    {
        AudioListener.volume = SoundSlider.value;
    }

    public void SoundButton()
    {
        ControlSound = !ControlSound;

        if (ControlSound == true)
        {
            AudioListener.pause = false;
            SoundButtonImage.sprite = OpenImage;
        }
        else
        {
            AudioListener.pause = true;
            SoundButtonImage.sprite = CloseImage;
        }        
    }

    public void ChangeAudioSlider()
    {
        if (SoundSlider.value == 0)
        {
            ControlSound = true;
            SoundButton();
        }
        else
        {
            ControlSound = false;
            SoundButton();
        }
    }
}

