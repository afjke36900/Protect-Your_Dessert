using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TeachPage : MonoBehaviour
{
    [Header("教學第一頁")]
    public CanvasGroup Page1;
    [Header("教學第二頁")]
    public CanvasGroup Page2;
    [Header("教學第三頁")]
    public CanvasGroup Page3;
    [Header("教學第四頁")]
    public CanvasGroup Page4;
    [Header("教學第五頁")]
    public CanvasGroup Page5;

    public void Teach1N()
    {
        Page1.alpha = 0;
        Page1.interactable = false;
        Page1.blocksRaycasts = false;
        Page2.alpha = 1;
        Page2.interactable = true;
        Page2.blocksRaycasts = true;
    }
    public void Teach2N()
    {
        Page2.alpha = 0;
        Page2.interactable = false;
        Page2.blocksRaycasts = false;
        Page3.alpha = 1;
        Page3.interactable = true;
        Page3.blocksRaycasts = true;
    }
    public void Teach3N()
    {
        Page3.alpha = 0;
        Page3.interactable = false;
        Page3.blocksRaycasts = false;
        Page4.alpha = 1;
        Page4.interactable = true;
        Page4.blocksRaycasts = true;
    }
    public void Teach4N()
    {
        Page4.alpha = 0;
        Page4.interactable = false;
        Page4.blocksRaycasts = false;
        Page5.alpha = 1;
        Page5.interactable = true;
        Page5.blocksRaycasts = true;
    }
    public void Teach5N()
    {
        Page5.alpha = 0;
        Page5.interactable = false;
        Page5.blocksRaycasts = false;
        SceneManager.LoadScene("Player Control Test");
    }
    public void Teach2B()
    {
        Page1.alpha = 1;
        Page1.interactable = true;
        Page1.blocksRaycasts = true;
        Page2.alpha = 0;
        Page2.interactable = false;
        Page2.blocksRaycasts = false;
    }
    public void Teach3B()
    {
        Page2.alpha = 1;
        Page2.interactable = true;
        Page2.blocksRaycasts = true;
        Page3.alpha = 0;
        Page3.interactable = false;
        Page3.blocksRaycasts = false;
    }
    public void Teach4B()
    {
        Page3.alpha = 1;
        Page3.interactable = true;
        Page3.blocksRaycasts = true;
        Page4.alpha = 0;
        Page4.interactable = false;
        Page4.blocksRaycasts = false;
    }
    public void Teach5B()
    {
        Page4.alpha = 1;
        Page4.interactable = true;
        Page4.blocksRaycasts = true;
        Page5.alpha = 0;
        Page5.interactable = false;
        Page5.blocksRaycasts = false;
    }
}
