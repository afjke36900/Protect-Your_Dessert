using UnityEngine;
using UnityEngine.UI;


public class Prop : MonoBehaviour
{
    [Header("道具")]
    public GameObject[] props;

    private int countTotal;

    private int CreateProp(GameObject prop, int count)
    {
        int total = count;
        //for迴圈
        for (int i = 0; i < total; i++)
        {
            //座標 = (隨機,1.5,隨機)
            Vector3 pos = new Vector3(Random.Range(-20, 20), 1.2f, Random.Range(-20, 20));
            //生成(物件,座標,角度)
            Instantiate(prop, pos, Quaternion.Euler(90, 0, 0));
        }

        return total;
    }

    private void Start()
    {
        CreateProp(props[0], 20);
    }


}
