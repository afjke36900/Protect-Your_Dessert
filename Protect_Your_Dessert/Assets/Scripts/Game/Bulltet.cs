using UnityEngine;
using UnityEngine.UI;

public class Bulltet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
        Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Monster")
        {
            Destroy(gameObject);
        }
    }


}
