using UnityEngine;

public class Controller : MonoBehaviour
{
    private Vector3 direction;
    [Header("移動速度"), Range(0,5)]
    public float speed = 0.2f;

    public Shooting bullet;

    private void Move()
    {

        //浮點數 前後值 = 輸入類別.取得軸向("垂直") 垂直WS上下
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");


        if (v == 1) direction = new Vector3(0, 0, 0);
        if (v == -1) direction = new Vector3(0, 180, 0);
        if (h == 1) direction = new Vector3(0, 90, 0);
        if (h == -1) direction = new Vector3(0, 270, 0);

        transform.eulerAngles = direction;

    }

    void Update()
    {
        if (Input.GetKey(GameManager.GM.forward))
            transform.position += Vector3.forward *speed;
        if (Input.GetKey(GameManager.GM.backward))
            transform.position += -Vector3.forward * speed;
        if (Input.GetKey(GameManager.GM.left))
            transform.position += Vector3.left * speed;
        if (Input.GetKey(GameManager.GM.right))
            transform.position += Vector3.right * speed;
        if (Input.GetKey(GameManager.GM.jump))
            transform.position += Vector3.up * speed;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void HitProp(GameObject prop)
    {
        if (prop.tag == "SpeedProp")
        {
            CancelInvoke("speeddown");
            speed = 0.4f;
            Destroy(prop);
            Invoke("speeddown", 3.5f);
        }
        else if (prop.tag == "BulletProp")
        {
            Destroy(prop);
            bullet.CountBullet += 30;
        }

    }


    private void speeddown()
    {
        speed = 0.2f;
    }




    private void OnTriggerEnter(Collider other)
    {
        //碰到道具時觸發HITPROP
        HitProp(other.gameObject);
    }
}
