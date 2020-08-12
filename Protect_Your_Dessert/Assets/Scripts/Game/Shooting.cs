using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    [Header("子彈發射處")]
    public Transform FirePoint;
    [Header("子彈")]
    public GameObject BULLET;

    [Header("子彈速度")]
    public float BulletForce = 10f;
    [Header("子彈數量")]
    public int CountBullet = 300;

    public Animator ani;
    public AudioSource aud;

    private void Start()
    {
        ani.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && CountBullet >0 ) 
        {
            Shoot();
            ani.SetTrigger("Shoot");
            aud.Play();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(BULLET, FirePoint.position, FirePoint.rotation);
        Rigidbody rig = bullet.GetComponent<Rigidbody>();
        rig.AddForce(FirePoint.forward * BulletForce, ForceMode.Impulse);

        CountBullet -= 1;
    }
}
