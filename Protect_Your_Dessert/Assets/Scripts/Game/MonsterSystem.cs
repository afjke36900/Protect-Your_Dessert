using UnityEngine;
using UnityEngine.UI;

public class MonsterSystem : MonoBehaviour
{
    [Header("怪物")]
    public GameObject[] monsters;

    private int CreateMonster(GameObject monster, int count)
    {
        int total = count;
        //for迴圈
        for (int i = 0; i < total; i++)
        {
            Vector2 _Creatmons_pos = new Vector2(0, 0);
            _Creatmons_pos += Random.Range(2, 9) * Rotate2D(Random.Range(0, 360));
            Instantiate(monster, new Vector3(_Creatmons_pos.x, 7.5f, _Creatmons_pos.y), Quaternion.Euler(0, 0, 0));
        }
        return total;
    }

    public Vector2 Rotate2D(float a)
    {
        a *= Mathf.Deg2Rad;
        return new Vector2(Mathf.Cos(a), Mathf.Sin(a));
    }



    private void Start()
    {
        CreateMonster(monsters[0], 8);
    }

}
