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

    private async void SpawnEnemy()
    {
        //Esto es para que de un numero aleatorio entre los Prefabs que puse en el Array
        int indexEnemy = Random.Range(0, enemyPrefabs.Length);
        //Esto es instanciar el enemigo, el transform es para que se instancia en la posición del Generator.
        Instantiate(enemyPrefabs[indexEnemy], transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
