using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    [Header("Configuration")]

    public List<GameObject> Prefabs;
    public float TimeBetweenSpawns = 3;
    public int SpawnArea;

    [Header("Debug")]
    public Vector3 SpawnerPosition;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateRandomObject", 0f, TimeBetweenSpawns);
    }

    public void InstantiateRandomObject()
    {
        //Genera una posicion aleatoria dentro del area
        Vector3 RandomPosition = Random.insideUnitCircle * SpawnArea;
        RandomPosition.z = 0f;

        // Instancia el objecto en la posicion generada
        GameObject RandomObj = Prefabs[Random.Range(0, Prefabs.Count)];
        GameObject NewObject = Instantiate(RandomObj, SpawnerPosition + RandomPosition, Quaternion.identity);

        //Asigna color aleatorio al sprite
        SpriteRenderer spriteRenderer = NewObject.GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }

        //almacenamos o asignamos el padre del objeto instanciado
        NewObject.transform.parent = transform;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(SpawnerPosition, SpawnArea);
    }
}
