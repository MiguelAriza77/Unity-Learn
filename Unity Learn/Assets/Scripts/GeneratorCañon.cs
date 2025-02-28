using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorCañon : MonoBehaviour
{
    public GameObject enemyPrefabs;

    //Cuanto se demora en salir el primer GameObject;
    public float delayTime = 2f;
    //Esto es el intervalo para que salga el siguiente GameObject
    public float intervalTime = 2f;


    void Start()
    {
        InvokeRepeating("Spawn", delayTime, intervalTime);
    }

    private void Spawn()
    {
        //int index = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
