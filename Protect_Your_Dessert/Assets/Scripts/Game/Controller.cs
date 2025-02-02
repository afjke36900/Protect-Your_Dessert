﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField]
    private float speed = 0.07f;

    public bool Canmove;

    public Animator ani;

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

        ani.SetBool("Run", Mathf.Abs(v) > 0 || Mathf.Abs(h) > 0);
        //ani.SetBool("Run", Mathf.Abs(v) > 0);

    }

    private void Start()
    {
        ani = GetComponent<Animator>();        
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
            speed = 0.1f;
            Destroy(prop);
            Invoke("speeddown", 3.5f);
        }
        else if (prop.tag == "BulletProp")
        {
            Destroy(prop);
            bullet.CountBullet += 50;
        }

    }


    private void speeddown()
    {
        speed = 0.07f;
    }




    private void OnTriggerEnter(Collider other)
    {
        //碰到道具時觸發HITPROP
        HitProp(other.gameObject);
    }


}
