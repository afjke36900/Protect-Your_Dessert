using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    [Header("怪物血量"), Range(0,100)]
    public float hp;
    private float speed=0.1f;

    protected NavMeshAgent agent;
    protected Animator ani;

    [Header("半徑"),Range(1,30)]
    public float radius = 10;
    private Vector3 final;
    /// <summary>
    /// 怪物轉向
    /// </summary>
    private Quaternion targetRotation;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        walk();
    }

    private void walk()
    {
        if(agent.remainingDistance<1.5f)
        { 
        //隨機座標 = 隨機.球內隨機點*10半徑 + 角色中心位置
        Vector3 RandomPos = Random.insideUnitSphere * radius + transform.position;
        //導覽網格碰撞 碰撞點
        NavMeshHit hit;
        //導覽網格.樣本座標(座標,碰撞點,半徑,圖層)
        //out執行方法會將結果儲存到傳入的參數內，執行後會將取得的隨機點儲存在hit內
        NavMesh.SamplePosition(RandomPos, out hit, radius, 1);
        //最終座標 = 碰撞點.座標
        final = hit.position;
        transform.rotation = Quaternion.Slerp(transform.localRotation, targetRotation, 0.8f);
        }
        agent.SetDestination(final);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            hp -= 10;
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
