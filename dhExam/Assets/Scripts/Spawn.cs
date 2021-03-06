using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float delay = 0.5f;

    private GameObject bombPrefab;

    private float lastTime;

    // Update is called once per frame
    private void Update()
    {
        if (Time.time - lastTime > delay)
        {
            SpawnBombFromPool();
        }
    }

    private void SpawnBomb()
    {
        lastTime = Time.time;

        Vector3 position = RandomPointInBox(transform.position, transform.localScale);

        var bomb = Instantiate(bombPrefab, position, Quaternion.identity);
    }

    private void SpawnBombFromPool()
    {
        lastTime = Time.time;

        Vector3 position = RandomPointInBox(transform.position, transform.localScale);

        var bomb = ObjPooling.Instance.GetFromPool();
        bomb.transform.position = position;
    }

    private static Vector3 RandomPointInBox(Vector3 center, Vector3 size)
    {

        return center + new Vector3(
            (Random.value - 0.5f) * size.x,
            (Random.value - 0.5f) * size.y,
            (Random.value - 0.5f) * size.z
        );
    }
}