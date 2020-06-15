using System.Collections;

using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    Transform menuPanel;
    Event keyEvent;
    Text buttonText;
    KeyCode newKey;

    bool waitingForKey;

    private void Start()
    {
        menuPanel = transform.Find("Panel");
        menuPanel.gameObject.SetActive(false);
        waitingForKey = false;
        
        for (int i = 0; i < 5; i++)
        {
            if (menuPanel.GetChild(i).name == "Downkey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.forward.ToString();
            else if (menuPanel.GetChild(i).name == "Backwardkey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.backward.ToString();
            else if (menuPanel.GetChild(i).name == "Leftkey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.left.ToString();
            else if (menuPanel.GetChild(i).name == "Rightkey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.right.ToString();
            else if (menuPanel.GetChild(i).name == "Jumpkey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.jump.ToString();
        }
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !menuPanel.gameObject.activeSelf)
            menuPanel.gameObject.SetActive(true);
        else if (Input.GetKeyDown(KeyCode.Escape) && menuPanel.gameObject.activeSelf)
            menuPanel.gameObject.SetActive(false);
    }

    void OnGUI()
    {
        keyEvent = Event.current;

        if(keyEvent.isKey && waitingForKey)
        {
            newKey = keyEvent.keyCode;
            waitingForKey = false;
        }
    }

    public void StarAssignment(string keyName)
    {
        if (!waitingForKey)
            StartCoroutine(AssignKey(keyName));
    }

    public void SendText(Text text)
    {
        buttonText = text;
    }

    IEnumerator WaitForKey()
    {
        while (!keyEvent.isKey)
            yield return null;
    }

    public IEnumerator AssignKey(string keyName)
    {
        waitingForKey = true;

        yield return WaitForKey();

        switch (keyName)
        {
            case "forward":
                GameManager.GM.forward = newKey;
                buttonText.text = GameManager.GM.forward.ToString();
                PlayerPrefs.SetString("forwardKey", GameManager.GM.forward.ToString());
                break;
            case "backward":
                GameManager.GM.forward = newKey;
                buttonText.text = GameManager.GM.forward.ToString();
                PlayerPrefs.SetString("backwardKey", GameManager.GM.forward.ToString());
                break;
            case "left":
                GameManager.GM.forward = newKey;
                buttonText.text = GameManager.GM.forward.ToString();
                PlayerPrefs.SetString("leftKey", GameManager.GM.forward.ToString());
                break;
            case "right":
                GameManager.GM.forward = newKey;
                buttonText.text = GameManager.GM.forward.ToString();
                PlayerPrefs.SetString("rightKey", GameManager.GM.forward.ToString());
                break;
            case "jump":
                GameManager.GM.forward = newKey;
                buttonText.text = GameManager.GM.forward.ToString();
                PlayerPrefs.SetString("jumpKey", GameManager.GM.forward.ToString());
                break;
        }
        yield return null;
    }
}
