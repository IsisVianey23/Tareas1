using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerySimpleSpawner : MonoBehaviour
{
    int spawnCount = 0;
    int spawnLimit = 10;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        while (spawnCount <= spawnLimit)
        {
            Instantiate(prefab, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);
            spawnCount++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
