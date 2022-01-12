using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnTouchH : MonoBehaviour
{
    public bool moving;
    public bool stop = false;
    public Vector3 velocity;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            collision.transform.SetParent(transform);
            moving = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            collision.transform.SetParent(null);
            if (stop)
            {
                moving = false;
            }
        }
    }
    private void FixedUpdate ()
    {
        if (moving)
        {
            transform.position += (velocity * Time.deltaTime);
        }
    }
}
