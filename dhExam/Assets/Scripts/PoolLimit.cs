using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolLimit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
        ObjPooling.Instance.AddToPool(gameObject);
    }

    private void Awake()
    {
        pooling();
    }

    int[] data;

    private void pooling()
    {
        data = new int[100];
        for (int i = 0; i < 100; i++)
        {
            data[i] = i;
        }
    }
}