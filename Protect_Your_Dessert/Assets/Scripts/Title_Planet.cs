using UnityEngine;

public class Title_Planet : MonoBehaviour
{
    public Transform rotate;
    
    // Update is called once per frame
    void Update()
    {
        rotate.Rotate(-15*Time.deltaTime,30 * Time.deltaTime,10 * Time.deltaTime);
    }
}
