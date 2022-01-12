using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject Enemy;
    public GameObject cage;

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Enemy.transform.position = spawnPoint.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Enemy.transform.position = cage.transform.position;
        }
    }
}