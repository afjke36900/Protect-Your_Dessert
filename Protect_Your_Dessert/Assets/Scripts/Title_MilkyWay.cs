using UnityEngine;

public class Title_MilkyWay : MonoBehaviour
{
    float speed = -0.1f;    // 速度

    void Update()
    {
        transform.Translate(Vector3.up *0.5f* speed * Time.deltaTime, Space.World);
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
    }
}


