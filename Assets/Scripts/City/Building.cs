using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
         renderer.material.SetFloat("_Scale", transform.localScale.y);
         renderer.material.SetFloat("_Offset",Random.Range(1, 2) * 600);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
