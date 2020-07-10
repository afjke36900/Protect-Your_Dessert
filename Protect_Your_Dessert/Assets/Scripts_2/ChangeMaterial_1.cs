using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial_1 : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            rend.sharedMaterial = material[1];
        }
        else if (col.gameObject.tag == "Monster")
        {
            rend.sharedMaterial = material[2];
        }
        else
        {
           // rend.sharedMaterial = material[1];
        }

    }
}
