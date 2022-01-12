using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject connectedDoor;
    public bool teleported = false;
    public GameObject doorPortPic;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (teleported && Input.GetAxisRaw("Vertical") < 1)
        {
            teleported = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetAxisRaw("Vertical") == 1)
        {
            if (Input.GetAxisRaw("Vertical") == 1 && !teleported)
            {
                doorPortPic.SetActive(true);
                player.transform.position = connectedDoor.transform.position;
                connectedDoor.GetComponent<Door>().teleported = true;
                StartCoroutine(WaitFor1Second());
            }
        }
    }
    public IEnumerator WaitFor1Second()
    {
        yield return new WaitForSeconds(0.4f);
        doorPortPic.SetActive(false);
    }
}