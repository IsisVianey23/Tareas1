using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
    [Header("Configuration")]

    public List<GameObject> Prefabs;
    public int RoundCount = 5;
    public float TimeBetweenRounds = 3;
    public int SpawnArea;

    [Header("Debug")]
    public float currentTime = 0f;
    public int currentRound = 0;


    // Start is called before the first frame update
    public void Spawner()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= TimeBetweenRounds)
        {
            ObjectGeneration();
            currentTime = 0f;
            currentRound++;

            if (currentRound >= RoundCount)
            {
                //Reiniciar el conteo de rondas
                currentRound = 0;

                //Ajustamos la frecuencia de generacion
                TimeBetweenRounds *= 0.9f;
            }
        }
    }

    // Update is called once per frame
    public void ObjectGeneration()
    {
        Vector3 SpawnPosition = new Vector3(Random.Range(-SpawnArea, SpawnArea),
                                           Random.Range(-SpawnArea, SpawnArea),
                                            0);

        GameObject obj = Prefabs[Random.Range(0, Prefabs.Count)];
        GameObject clone = Instantiate(obj, SpawnPosition, Quaternion.identity);
    }

    void Update()
    {
        Spawner();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(-SpawnArea, SpawnArea));
    }
}