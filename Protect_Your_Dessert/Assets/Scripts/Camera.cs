using UnityEngine;

public class Camera : MonoBehaviour
{

    /// <summary>
    /// 玩家變形元件
    /// </summary>
    private Transform player;
    [Header("追蹤速度"), Range(0.1f, 50.5f)]
    public float speed = 8f;


    /// <summary>
    /// 追蹤玩家
    /// </summary>
    private void Track()
    {
        //攝影機與玩家y軸距離 7
        //攝影機與玩家z軸距離 -4
        Vector3 posTrack = player.position;
        posTrack.y += 11f;
        posTrack.z += -4f;

        //攝影機座標 = 變形.座標
        Vector3 posCam = transform.position;
        //攝影機座標 = 三維向量(Animation,Behaviour,百分比)
        posCam = Vector3.Lerp(posCam, posTrack, 0.8f * Time.deltaTime * speed);
        //變形.座標 = 攝影機座標
        transform.position = posCam;
    }

    private void Start()
    {
        player = GameObject.Find("PlayerTest").transform;
    }

    private void LateUpdate()
    {
        Track();
    }

}
