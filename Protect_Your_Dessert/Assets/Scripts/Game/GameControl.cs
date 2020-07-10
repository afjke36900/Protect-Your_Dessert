using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public KeyCode jump = KeyCode.Space;
    public KeyCode forward = KeyCode.W;
    public KeyCode left = KeyCode.A;
    public KeyCode backward = KeyCode.S;
    public KeyCode right = KeyCode.D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jump))
        {
            print("跳躍");
        }
        if (Input.GetKeyDown(forward))
        {
            print("前進");
        }
        if (Input.GetKeyDown(left))
        {
            print("向左");
        }
        if (Input.GetKeyDown(backward))
        {
            print("後退");
        }
        if (Input.GetKeyDown(right))
        {
            print("向右");
        }
    }

    public void ChangeKey(KeyCode key)
    {
        jump = key;
        forward = key;
        left = key;
        backward = key;
        right = key;
    }
}
