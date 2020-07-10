
using UnityEngine;

public class Floor : MonoBehaviour
{
    [Header("地板")]
    public GameObject cube;

    private void CreatFloor(int length, int width)
    {
        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < length; i++)
            {
                //API實例化(生成)
                //生成(物件、座標、角度)
                //Vector3三圍向量(保存三個浮點數)
                //Quaternion 角度
                //Quaternion.identity 零角度
                //Quaternion.Euler (x,y,z) 歐拉角度 - 0~360
                Instantiate(cube, new Vector3(j , 0, i ), Quaternion.Euler(270, 0, 0));
            }
        }
    }

    private void Awake()
    {
        CreatFloor(100, 100);
    }

}
