using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour
{

    public float spawnTime = 5f;
    public float frequency = 3f;
    public GameObject[] enemies;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", frequency, spawnTime);
    }

    void Spawn()
    {
        // Instantiate a random enemy.
        int enemyIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[enemyIndex], transform.position, transform.rotation);
    }
}