using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Ctrl : MonoBehaviour
{
    bool ControlSound;

    public void SoundButton()
    {
        ControlSound = !ControlSound;
        AudioListener.pause = ControlSound;
    }
}

