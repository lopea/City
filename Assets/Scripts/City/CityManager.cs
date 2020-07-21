using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour
{
    public GameObject prefab;


    private void Awake()
    {
        for(int i = 0; i < 10; i ++)
        {
            for(int j = 0; j < 10; j ++)
            {
                var inst = Instantiate(prefab,new Vector3(i, 0, j), Quaternion.identity);
                inst.transform.localScale = new Vector3(1,Random.Range(0,10), 1);
            }
        }
    }

}
