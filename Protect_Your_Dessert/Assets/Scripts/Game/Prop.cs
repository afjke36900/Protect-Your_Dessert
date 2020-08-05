using UnityEngine;
using UnityEngine.UI;


public class Prop : MonoBehaviour
{
    [Header("道具")]
    public GameObject[] props;

    private int countTotal;

    //原方形生成
    /*private int CreateProp(GameObject prop, int count)
    {
        int total = count;
        //for迴圈
        for (int i = 0; i < total; i++)
        {
            //座標 = (隨機,高度,隨機)
            Vector3 pos = new Vector3(Random.Range(-9,9), 6.75f, Random.Range(-9, 9));
            //生成(物件,座標,角度)
            Instantiate(prop, pos, Quaternion.Euler(90, 0, 0));
        }

        return total;
    }*/
    
    /// <summary>
    /// 圓形生成(不知道怎麼寫的)
    /// </summary>
    /// <param name="prop"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    private int RandomCreate(GameObject prop,int count)
    {         
        int total = count;
        //for迴圈
        for (int i = 0; i < total; i++)
        {
            Vector2 _Creatprop_pos=new Vector2(0,0);
            _Creatprop_pos +=   Random.Range(0, 9) * Rotate2D(Random.Range(0, 360));
        Instantiate(prop, new Vector3(_Creatprop_pos.x, 6.75f, _Creatprop_pos.y), Quaternion.Euler(0,0,0));
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
        RandomCreate(props[0], 10);
        RandomCreate(props[1], 20);
    }


}
