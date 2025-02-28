using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 direction = new Vector3 (0f, 0f, 1f); //Esto es lo mismo que Vector3.forward;
    public float speed = 2f;
    public float delaylimit = 3f;
    void Start()
    {
        Invoke("DeleteGameObject", delaylimit);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        //transform.position += direction * speed * Time.deltaTime;
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void DeleteGameObject()
    {
        Debug.Log("BALA ELMINADA");
        Destroy(gameObject);
    }
}
