﻿using UnityEngine;
using UnityEngine.UI;

public class GameSet : MonoBehaviour
{
    [Header("螢幕解析度")]
    public Dropdown ScreenSizeDropdown;

    void Start()
    {
        
    }
        
    void Update()
    {
        #region 螢幕解析度 if 寫法
        //if (toggle == false)
        //{
                    if (ScreenSizeDropdown.value == 0)
                    {
                        Screen.SetResolution(1920, 1080, false);    
                    }

                    if (ScreenSizeDropdown.value == 1)
                    {
                        Screen.SetResolution(1280, 720, false);
                    }

                    if (ScreenSizeDropdown.value == 2)
                    {
                        Screen.SetResolution(960, 540, false);    
                    }

                    if (ScreenSizeDropdown.value == 3)
                    {
                        Screen.SetResolution(1920, 1080, true);     
        }
        //}
        //else
        //{
            
        //}
        #endregion

        #region 螢幕解析度 Switch 寫法
        /*
        switch (ScreenSizeDropdown.value)
        {
            case 0:
                Screen.SetResolution(1280, 720, false);
                break;
            case 1:
                Screen.SetResolution(1920, 1080, false);
                break;
            case 2:
                Screen.SetResolution(960, 540, false);
                break;
        }
        */
        #endregion
    }
}
