using UnityEngine;
using UnityEngine.UI;

public class MonsterSystem : MonoBehaviour
{
    [Header("怪物")]
    public GameObject[] monsters;

    private int CreateProp(GameObject monster, int count)
    {
        int total = count;
        //for迴圈
        for (int i = 0; i < total; i++)
        {
            //座標 = (隨機,1.5,隨機)
            Vector3 pos = new Vector3(Random.Range(5, 55), 0.5f, Random.Range(5, 45));
            //生成(物件,座標,角度)
            Instantiate(monster, pos, Quaternion.Euler(0, 0, 0));
        }

        return total;
    }

    private void Start()
    {
        CreateProp(monsters[0], 8);
    }

}
