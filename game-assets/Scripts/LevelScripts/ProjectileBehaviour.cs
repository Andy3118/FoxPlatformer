using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float Speed = 4.5f;
    public bool dirLeft;

    private void Update()
    {
        if (dirLeft == true)
        {
            transform.position += -transform.right * Time.deltaTime * Speed;
        }
        else
        {
            transform.position += transform.right * Time.deltaTime * Speed;
        }
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FallDetector" || other.tag =="Ground")
        {
            Destroy(gameObject);
        }
    }
}
