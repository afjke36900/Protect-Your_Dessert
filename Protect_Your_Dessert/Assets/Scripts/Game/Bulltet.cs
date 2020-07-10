using UnityEngine;
using UnityEngine.UI;

public class Bulltet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


}
