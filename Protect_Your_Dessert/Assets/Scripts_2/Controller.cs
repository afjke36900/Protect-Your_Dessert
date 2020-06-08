using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(GameManager.GM.forward))
            transform.position += Vector3.forward / 20;
        if (Input.GetKey(GameManager.GM.backward))
            transform.position += -Vector3.forward / 20;
        if (Input.GetKey(GameManager.GM.left))
            transform.position += Vector3.left / 20;
        if (Input.GetKey(GameManager.GM.right))
            transform.position += Vector3.right / 20;
        if (Input.GetKey(GameManager.GM.jump))
            transform.position += Vector3.up / 20;
    }
}
