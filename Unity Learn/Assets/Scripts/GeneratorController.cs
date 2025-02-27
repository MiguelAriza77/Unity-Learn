using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    //public GameObject enemyPrefab;
    public GameObject[] enemyPrefabs;
    public float delayTime = 2f;
    public float intervalSpawn = 2f;
    void Start()
    {

        InvokeRepeating("SpawnEnemy", delayTime, intervalSpawn);
        //SpawnEnemy();
        //SpawnEnemy();
        //SpawnEnemy();

    }

    private void SpawnEnemy()
    {
        int indexEnemy = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[indexEnemy], transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
