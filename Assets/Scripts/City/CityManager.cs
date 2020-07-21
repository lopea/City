using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour
{

    
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 20; j ++)
            {
                var instance= GameObject.CreatePrimitive(PrimitiveType.Cube);

                instance.transform.localScale =new Vector3(1,Random.Range(1 , 10),1);
                instance.transform.position = new Vector3(i,0,j);
            }
        }
    }

}
