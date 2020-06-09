﻿using UnityEngine;

public class Charactor : MonoBehaviour
{
    [Header("移動速度"), Range(1, 200)]
    public float speed = 15;

    private Vector3 direction;
    private Rigidbody rig;

    private void Move()
    {

        //浮點數 前後值 = 輸入類別.取得軸向("垂直") 垂直WS上下
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        //剛體, 添加推力(x,y,z) - 世界座標
        //rig.AddForce(0, 0, speed*v);
        //剛體.添加推力(三維向量) - 區域座標
        /*前方 transform.forward - z
          右方 transform.right   - x
          上方 transform.up      - y */

        rig.AddForce(transform.forward * speed * Mathf.Abs(v));
        rig.AddForce(transform.forward * speed * Mathf.Abs(h));


        if (v == 1) direction = new Vector3(0, 0, 0);
        if (v == -1) direction = new Vector3(0, 180, 0);
        if (h == 1) direction = new Vector3(0, 90, 0);
        if (h == -1) direction = new Vector3(0, 270, 0);

        transform.eulerAngles = direction;

    }

    private void Start()
    {
        //GetComponent<泛型>() 泛型方法 泛型 所有類型 Rigidbody,Transform,Collider
        //剛體 = 取得元件<剛體>();
        rig = GetComponent<Rigidbody>();


    }

    private void FixedUpdate()
    {
        Move();
    }
}
